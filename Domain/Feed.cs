using System;
using System.ComponentModel.DataAnnotations;

namespace DesignPatterObserver.Domain;
public class Feed : IObserver
{
    public Feed(string url, string title)
    {
        URL = url;
        Title = title;
    }
    public void Update(Video video)
    {
        Console.WriteLine($"New video added in Feed RSS: {Title}");
        Console.WriteLine($"Check this out : {URL}");
    }
    public string Title { get; set; }
    public string URL { get; set; }
}
