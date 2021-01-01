namespace StrategyPattern.ObserverPattern.General
{
    public interface IObserver<T>
    { 
        public void Update(T value);
    }
}