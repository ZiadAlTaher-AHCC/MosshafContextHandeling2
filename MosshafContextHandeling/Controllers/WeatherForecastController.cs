using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MosshafContextHandeling.Helpers;
using MosshafContextHandeling.MainModels.NewModels;
using MosshafContextHandeling.Models;
using System.Data.Common;
using System.Reflection;

namespace MosshafContextHandeling.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            using (var oldContext = new Quran_quran3Context())
            using (var newContext = new Quran_quran4Context())
            {
                var entityTypes = newContext.Model
                  .GetEntityTypes()
                  .Select(e => e.ClrType)
                  .Where(t => !t.IsAbstract)
                  .ToList();

                foreach (var entityType in entityTypes)
                {
                    try
                    {
                        var method = typeof(WeatherForecastController)
                            .GetMethod(nameof(MigrateTable))
                            .MakeGenericMethod(entityType);

                        await (Task)method.Invoke(this, new object[] { oldContext, newContext });
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error migrating {entityType.Name}");
                        Console.WriteLine(ex);
                    }
                }
            }

            //var newContext = new Quran_quran4Context();
            //var olomBook = await newContext.MogamBooks
            //    .Include(b => b.MogamChapters)
            //        .ThenInclude(c => c.MogamBabs)
            //            .ThenInclude(b => b.Mogams)
            //    .FirstOrDefaultAsync();


            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
.ToArray();
        }




        public async Task MigrateTable<T>(DbContext oldContext, DbContext newContext) where T : class, new()
        {
            Type type = typeof(T);

            string oldTableName = type.GetCustomAttribute<OldNameAttribute>()?.OldName;
            if (string.IsNullOrEmpty(oldTableName))
            {
                Console.WriteLine($"Skipping type {type.Name}: OldNameAttribute is missing on the class.");
                return;
            }

            var columnMappings = new List<(string OldColumn, PropertyInfo NewProperty)>();
            var properties = type.GetProperties();

            foreach (var prop in properties)
            {
                var oldNameAttr = prop.GetCustomAttribute<OldNameAttribute>();
                // تجاهل الخصائص التي لا تحمل الـ OldNameAttribute
                if (oldNameAttr != null)
                {
                    columnMappings.Add((oldNameAttr.OldName, prop));
                }
            }

            string oldColumnsList = string.Join(", ", columnMappings.Select(m => $"[{m.OldColumn}]"));

            string selectQuery = $"SELECT {oldColumnsList} FROM [quran_quran2].[{oldTableName}]";

            var oldDataList = new List<T>();

            DbConnection connection = oldContext.Database.GetDbConnection();
            await connection.OpenAsync();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = selectQuery;

                using (var reader = await command.ExecuteReaderAsync())
                {
                    // الحصول على الـ Index لكل عمود قديم من الـ Reader
                    var readerMap = columnMappings.Select(m => (m.NewProperty, reader.GetOrdinal(m.OldColumn))).ToList();

                    while (await reader.ReadAsync())
                    {
                        var newItem = new T();
                        foreach (var (newProperty, columnIndex) in readerMap)
                        {
                            // جلب القيمة والتحقق من DBNull
                            if (!reader.IsDBNull(columnIndex))
                            {
                                object value = reader.GetValue(columnIndex);

                                // تعيين القيمة للخاصية الجديدة (مع معالجة تحويل النوع)
                                try
                                {
                                    Type targetType = newProperty.PropertyType;
                                    // التعامل مع الأنواع القابلة للقيمة Null (مثل int?)
                                    if (targetType.IsGenericType && targetType.GetGenericTypeDefinition() == typeof(Nullable<>))
                                    {
                                        targetType = Nullable.GetUnderlyingType(targetType);
                                    }

                                    newProperty.SetValue(newItem, Convert.ChangeType(value, targetType));
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Error mapping value '{value}' to property {newProperty.Name} ({newProperty.PropertyType.Name}): {ex.Message}");
                                    // يمكن اتخاذ قرار هنا: إما تجاهل هذا السجل أو تعيينه إلى null إذا كان ممكناً
                                    newProperty.SetValue(newItem, null);
                                }
                            }
                            else
                            {
                                if (newProperty.PropertyType.IsGenericType && newProperty.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                                {
                                    newProperty.SetValue(newItem, null);
                                }
                                // إذا كان غير قابل لـ null، فسيتم ترك القيمة الافتراضية للنوع (مثل 0 لـ int)
                            }
                        }
                        oldDataList.Add(newItem);
                    }
                }
            }
            await connection.CloseAsync();

            Console.WriteLine($"Successfully read {oldDataList.Count} records from table {oldTableName}.");

            if (oldDataList.Any())
            {
                newContext.Set<T>().AddRange(oldDataList);

                int savedCount = await newContext.SaveChangesAsync();
                Console.WriteLine($"Successfully inserted {savedCount} records into the new database for type {type.Name}.");
            }
            else
            {
                Console.WriteLine($"No data to insert for type {type.Name}.");
            }
        }
    }
}
