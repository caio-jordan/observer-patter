using DesignPatterObserver.Domain;
using System;

class Program
{
    static void Main(string[] args)
    {
        var newVideo = new Video("How Open The Doors", "This is video will you learn hot to open the door", "www.youtube.com.br/thedoor");

        var videoNotification = new VideoNotification(newVideo);

        // Observers
        var paulo = new Subscriber("Paulo Pena");
        var cleber = new Subscriber("Cleber Casa Grande");
        var tiago = new Subscriber("Tiago Toes");
        var feedYoutube = new Feed("www.youtube.com.br/howToMakeRiceAndBeans", "How to Make Rice and Beans");

        videoNotification.Subscribe(paulo);
        videoNotification.Subscribe(cleber);
        videoNotification.Subscribe(tiago);
        videoNotification.Subscribe(feedYoutube);

        Console.WriteLine("Notify all observers...");
        videoNotification.NotifyAll();

        // Unsubscribe Cleber Casa Grande
        videoNotification.Unsubscribe(tiago);

        // Notify again
        Console.WriteLine("Notify all observers...");
        videoNotification.NotifyAll();

        Console.ReadLine();
    }
}