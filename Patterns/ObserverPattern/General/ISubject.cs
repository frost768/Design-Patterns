namespace StrategyPattern.ObserverPattern.General
{
    public interface ISubject<T>
    {
        public void RegisterObserver(IObserver<T> observer);
        public void RemoveObserver(IObserver<T> observer);
        public void NotifyObservers();
    }
    
}