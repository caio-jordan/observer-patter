public class Subscriber : IObserver
{
    public Subscriber(string name) => Name = name;
    public void Update(Video video)
    {
        Console.WriteLine($"{Name} has been notified about: {video.Title}");
    }
    public string Name { get; set; }
}