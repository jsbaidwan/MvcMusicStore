namespace MvcMusicStore.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public Album Album { get; set; }

        public string Contents { get; set; }

        public string ReviewerEmail { get; set; }
    }
}