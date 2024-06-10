public class VideoNotification : ISubject
{
    private List<IObserver> observers = new List<IObserver>();

    public readonly Video video;

    public VideoNotification(Video video)
    {
        this.video = video;
    }

    public void Subscribe(IObserver sub)
    {
        observers.Add(sub);
    }

    public void Unsubscribe(IObserver sub)
    {
        observers.Remove(sub);
    }

    public void UnsubscribeAll()
    {
        observers.Clear();
    }

    public void Notify(IObserver sub)
    {
        sub.Update(video);
    }

    public void NotifyAll()
    {
        foreach (var sub in observers)
        {
            Notify(sub);
        }
    }    
}