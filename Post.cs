namespace livecoding_ASP.NET_first_project
{
    public class Post
    {
        public int Id = 0;
        public string Title { get; set; }
        public string Content { get; set; }

        public string ImageUrl { get; set; }

        public Post(string title, string content, string imageUrl)
        {
            Title = title;
            Content = content;
            ImageUrl = imageUrl;
            Id = new Random().Next(1, 999999);
        }
    }
}
