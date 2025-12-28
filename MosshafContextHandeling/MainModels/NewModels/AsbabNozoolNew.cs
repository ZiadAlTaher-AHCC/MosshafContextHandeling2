using MosshafContextHandeling.Helpers;

namespace MosshafContextHandeling.MainModels.NewModels
{
    public class AsbabNozoolNew
    {

        public int Id { get; set; }

        [OldName("QuranID")]
        public int AyaId { get; set; }
        public Aya Aya { get; set; }

        public string Text { get; set; }

        public int? AsbabNozoolBookId { get; set; }
        public AsbabNozoolBook AsbabNozoolBook { get; set; }
    }
}
