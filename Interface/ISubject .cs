public interface ISubject
{
    public void Subscribe(IObserver observer);
    public void Unsubscribe(IObserver observer);
    public void UnsubscribeAll();
    public void Notify(IObserver observer);
    public void NotifyAll();
}