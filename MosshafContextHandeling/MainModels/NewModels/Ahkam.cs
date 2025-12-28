namespace MosshafContextHandeling.MainModels.NewModels
{
    public class Ahkam
    {
        public int Id { get; set; }

        //[OldName("QuranID")]
        public int AyaId { get; set; }
        public Aya Aya { get; set; }

        public string Text { get; set; }

        public int AhkamBookId { get; set; }
        public AhkamBook AhkamBook { get; set; }
    }
}
