namespace SecondWebApp.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PublishUser { get; set; }
        public int Like { get; set; }
        public int Comments { get; set; }
        public string Desciption { get; set; }
        public string PhotoUrl { get; set; }

    }
}