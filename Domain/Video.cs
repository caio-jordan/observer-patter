public class Video
{
    public Video(string title, string description, string link)
    {
        Title = title;
        Description = description;
        Link = link;
    }
    public int Id => new Random().Next();
    public string Title { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
}