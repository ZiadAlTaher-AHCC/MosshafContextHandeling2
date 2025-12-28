using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MosshafContextHandeling.Helpers;
using MosshafContextHandeling.MainModels.NewModels;
using System.Data.Common;
using System.Reflection;

namespace MosshafContextHandeling.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        //public static IQueryable<TResult> SelectDynamic<T, TResult>(
        //    IQueryable<T> query,
        //    string propertyName)
        //        {
        //            var parameter = Expression.Parameter(typeof(T), "x");
        //            var property = Expression.Property(parameter, propertyName);
        //            var lambda = Expression.Lambda<Func<T, TResult>>(property, parameter);

        //            return query.Select(lambda);
        //        }

        //static readonly Dictionary<string, string> TafseerOldNameMap =
        //    typeof(Tafseer).GetProperties()
        //    .Select(p => new
        //    {
        //        PropName = p.Name,
        //        Attr = p.GetCustomAttribute<OldNameAttribute>()
        //    })
        //    .Where(x => x.Attr != null)
        //    .ToDictionary(x => x.Attr.OldName, x => x.PropName);


        //static readonly Dictionary<string, string> AhkamOldNameMap =
        //    typeof(Ahkam).GetProperties()
        //    .Select(p => new
        //    {
        //        PropName = p.Name,
        //        Attr = p.GetCustomAttribute<OldNameAttribute>()
        //    })
        //    .Where(x => x.Attr != null)
        //    .ToDictionary(x => x.Attr.OldName, x => x.PropName);


        //static readonly Dictionary<string, string> AsbabNozoolOldNameMap =
        //    typeof(AsbabNozool).GetProperties()
        //    .Select(p => new
        //    {
        //        PropName = p.Name,
        //        Attr = p.GetCustomAttribute<OldNameAttribute>()
        //    })
        //    .Where(x => x.Attr != null)
        //    .ToDictionary(x => x.Attr.OldName, x => x.PropName);

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };



        static readonly Dictionary<string, string> TragemOldNameMap =
            typeof(Tragem).GetProperties()
            .Select(p => new
            {
                PropName = p.Name,
                Attr = p.GetCustomAttribute<OldNameAttribute>()
            })
            .Where(x => x.Attr != null)
            .ToDictionary(x => x.Attr.OldName, x => x.PropName);

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {

            var newContext = new Quran_quran4Context();

            var TragemBooks = await newContext.AhkamBooks
                .Include(a => a.Ahkams)
                .ToListAsync();

            foreach (var book in TragemBooks)
            {
                //if (!TragemOldNameMap.TryGetValue(book.MappedColumnName, out var propertyName))
                //{
                //    _logger.LogWarning(
                //        "MappedColumnName '{MappedColumnName}' not found in Tragem properties. BookId = {BookId}",
                //        book.MappedColumnName,
                //        book.Id
                //    );

                //    // عدّي اللفة دي
                //    continue;
                //}

                //var parameter = Expression.Parameter(typeof(Tragem), "t");

                //var bindings = new List<MemberBinding>
                //{
                //    // TragemNew.AyaId = t.AyaId
                //    Expression.Bind(
                //        typeof(Tragem).GetProperty(nameof(Tragem.AyaId))!,
                //        Expression.Property(parameter, nameof(Tragem.AyaId))
                //    ),

                //    // TragemNew.Text = t.<dynamic property>
                //    Expression.Bind(
                //        typeof(Tragem).GetProperty(nameof(Tragem.Text))!,
                //        Expression.Property(parameter, propertyName)
                //    )
                //};

                //var body = Expression.MemberInit(
                //    Expression.New(typeof(Tragem)),
                //    bindings
                //);

                //var selector = Expression.Lambda<Func<Tragem, Tragem>>(body, parameter);

                //var result = await newContext.Tragems
                //    .AsNoTracking()
                //    .Select(selector)
                //    .ToListAsync();

                //// ربط الكتاب
                //foreach (var item in result)
                //    item.TragemBookId = book.Id;

                //newContext.TragemsNew.AddRange(result);
                await newContext.SaveChangesAsync();
            }


            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
.ToArray();
        }

        //public static PropertyInfo GetPropertyByOldName<T>(string oldName)
        //{
        //    return typeof(T).GetProperties()
        //        .FirstOrDefault(p =>
        //            p.GetCustomAttributes(typeof(OldNameAttribute), false)
        //             .Cast<OldNameAttribute>()
        //             .Any(a => a.OldName == oldName));
        //}


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
//using (var oldContext = new Quran_quran3Context())
//using (var newContext = new Quran_quran4Context())
//{
//    var entityTypes = newContext.Model
//      .GetEntityTypes()
//      .Select(e => e.ClrType)
//      .Where(t => !t.IsAbstract)
//      .ToList();

//    foreach (var entityType in entityTypes)
//    {
//        try
//        {
//            var method = typeof(WeatherForecastController)
//                .GetMethod(nameof(MigrateTable))
//                .MakeGenericMethod(entityType);

//            await (Task)method.Invoke(this, new object[] { oldContext, newContext });
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Error migrating {entityType.Name}");
//            Console.WriteLine(ex);
//        }
//    }
//}




//var Tafseers = await newContext.Tafseers.Select(b =>new {b.Id,text= "using reflection get the property that carry  [OldName(\"ta7reer1\")]").ToList()
//    .Include(b => b.MogamChapters)
//        .ThenInclude(c => c.MogamBabs)
//            .ThenInclude(b => b.Mogams)
//    .FirstOrDefaultAsync();
//var oldName = "ta7reer1";

//var prop = GetPropertyByOldName<Tafseer>(oldName);

//if (prop == null)
//    throw new Exception($"No property mapped with OldName = {oldName}");

//var tafseers = await newContext.Tafseers
//    .AsNoTracking()
//    .ToListAsync();

//var result = tafseers.Select(t => new
//{
//    t.Id,
//    Text = prop.GetValue(t)
//}).ToList();
//////////////////////////////////////////////////

//var oldName = "ta7reer1";

//var prop = GetPropertyByOldName<Tafseer>(oldName);

//if (prop == null)
//    throw new Exception($"No property mapped with OldName = {oldName}");

//var tafseers = await newContext.Tafseers
//    //.AsNoTracking()
//    .Where(t => t.AyaId == 1)
//    .ToListAsync();

//var result = tafseers.Select(t => new
//{
//    t.Id,
//    Text = prop.GetValue(t)
//}).ToList();

/////////////////////////////////////
///

//// SELECT عمود واحد بس من DB
//var texts = await SelectDynamic<Tafseer, string>(
//        newContext.Tafseers.AsNoTracking(),
//        propertyName)
//    .Take(5)
//    .ToListAsync();




//var tafseerBooks = await newContext.TafseerBooks
//  .AsNoTracking()
//  .ToListAsync();

//foreach (var book in tafseerBooks)
//{
//    // اسم البروبرتي الحقيقي في Tafseer
//    var propertyName = TafseerOldNameMap[book.MappedColumnName];

//    var parameter = Expression.Parameter(typeof(Tafseer), "t");

//    var bindings = new List<MemberBinding>
//    {
//        //// Tafser.Id = t.Id
//        //Expression.Bind(
//        //    typeof(Tafser).GetProperty(nameof(Tafser.Id))!,
//        //    Expression.Property(parameter, nameof(Tafseer.Id))
//        //),

//        // Tafser.AyaId = t.AyaId
//        Expression.Bind(
//            typeof(Tafser).GetProperty(nameof(Tafser.AyaId))!,
//            Expression.Property(parameter, nameof(Tafseer.AyaId))
//        ),

//        // Tafser.Text = t.<dynamic property>
//        Expression.Bind(
//            typeof(Tafser).GetProperty(nameof(Tafser.Text))!,
//            Expression.Property(parameter, propertyName)
//        )
//    };

//    var body = Expression.MemberInit(
//        Expression.New(typeof(Tafser)),
//        bindings
//    );

//    var selector = Expression.Lambda<Func<Tafseer, Tafser>>(body, parameter);

//    var result = await newContext.Tafseers
//        .AsNoTracking()
//        .Select(selector)
//        .ToListAsync();

//    // ربط الكتاب
//    foreach (var item in result)
//        item.TafseerBookId = book.Id;

//    newContext.Tafsers.AddRange(result);
//    await newContext.SaveChangesAsync();
//}





//var ahkamBooks = await newContext.AhkamBooks
//.AsNoTracking()
//.ToListAsync();

//foreach (var book in ahkamBooks)
//{
//    // اسم البروبرتي الحقيقي في Ahkam
//    var propertyName = AhkamOldNameMap[book.MappedColumnName];

//    var parameter = Expression.Parameter(typeof(Ahkam), "t");

//    var bindings = new List<MemberBinding>
//    {
//        //// Ahhkam.Id = t.Id
//        //Expression.Bind(
//        //    typeof(Ahhkam).GetProperty(nameof(Ahhkam.Id))!,
//        //    Expression.Property(parameter, nameof(Ahhkam.Id))
//        //),

//        // Ahhkam.AyaId = t.AyaId
//        Expression.Bind(
//            typeof(Ahhkam).GetProperty(nameof(Ahhkam.AyaId))!,
//            Expression.Property(parameter, nameof(Ahkam.AyaId))
//        ),

//        // Ahhkam.Text = t.<dynamic property>
//        Expression.Bind(
//            typeof(Ahhkam).GetProperty(nameof(Ahhkam.Text))!,
//            Expression.Property(parameter, propertyName)
//        )
//    };

//    var body = Expression.MemberInit(
//        Expression.New(typeof(Ahhkam)),
//        bindings
//    );

//    var selector = Expression.Lambda<Func<Ahkam, Ahhkam>>(body, parameter);

//    var result = await newContext.Ahkams
//        .AsNoTracking()
//        .Select(selector)
//        .ToListAsync();

//    // ربط الكتاب
//    foreach (var item in result)
//        item.AhkamBookId = book.Id;

//    newContext.Ahhkams.AddRange(result);
//    await newContext.SaveChangesAsync();
//}



//var AsbabNozoolBooks = await newContext.AsbabNozoolBooks
//.AsNoTracking()
//.ToListAsync();

//foreach (var book in AsbabNozoolBooks)
//{
//    // اسم البروبرتي الحقيقي في AsbabNozool
//    var propertyName = AsbabNozoolOldNameMap[book.MappedColumnName];

//    var parameter = Expression.Parameter(typeof(AsbabNozool), "t");

//    var bindings = new List<MemberBinding>
//    {
//        //// AsbabNozoolNew.Id = t.Id
//        //Expression.Bind(
//        //    typeof(AsbabNozoolNew).GetProperty(nameof(AsbabNozoolNew.Id))!,
//        //    Expression.Property(parameter, nameof(AsbabNozoolNew.Id))
//        //),

//        // AsbabNozoolNew.AyaId = t.AyaId
//        Expression.Bind(
//            typeof(AsbabNozoolNew).GetProperty(nameof(AsbabNozoolNew.AyaId))!,
//            Expression.Property(parameter, nameof(AsbabNozool.AyaId))
//        ),

//        // AsbabNozoolNew.Text = t.<dynamic property>
//        Expression.Bind(
//            typeof(AsbabNozoolNew).GetProperty(nameof(AsbabNozoolNew.Text))!,
//            Expression.Property(parameter, propertyName)
//        )
//    };

//    var body = Expression.MemberInit(
//        Expression.New(typeof(AsbabNozoolNew)),
//        bindings
//    );

//    var selector = Expression.Lambda<Func<AsbabNozool, AsbabNozoolNew>>(body, parameter);

//    var result = await newContext.AsbabNozools
//        .AsNoTracking()
//        .Select(selector)
//        .ToListAsync();

//    // ربط الكتاب
//    foreach (var item in result)
//        item.AsbabNozoolBookId = book.Id;

//    newContext.AsbabNozoolsNew.AddRange(result);
//    await newContext.SaveChangesAsync();
//}


