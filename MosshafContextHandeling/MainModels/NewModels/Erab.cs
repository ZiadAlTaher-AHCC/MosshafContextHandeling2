using MosshafContextHandeling.Helpers;

namespace MosshafContextHandeling.MainModels.NewModels
{
    public class Erab
    {

        public int Id { get; set; }

        [OldName("QuranID")]
        public int AyaId { get; set; }
        public Aya? Aya { get; set; }

        public string Text { get; set; }

        public int ErabBookId { get; set; }
        public ErabBook? ErabBook { get; set; }
    }
}
