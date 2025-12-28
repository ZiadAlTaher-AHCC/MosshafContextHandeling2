namespace MosshafContextHandeling.MainModels.NewModels
{
    public class TragemNew
    {
        public int Id { get; set; }

        public int AyaId { get; set; }
        public Aya Aya { get; set; }

        public string Text { get; set; }

        public int? TragemBookId { get; set; }
        public TragemBook TragemBook { get; set; }
    }
}
