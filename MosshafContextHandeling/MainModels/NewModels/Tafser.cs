namespace MosshafContextHandeling.MainModels.NewModels
{
    public class Tafser
    {
        public int? Id { get; set; }

        //[OldName("QuranID")]
        public int? AyaId { get; set; }
        public Aya Aya { get; set; }

        public string Text { get; set; }

        public int? TafseerBookId { get; set; }
        public TafseerBook TafseerBook { get; set; }
    }
}
