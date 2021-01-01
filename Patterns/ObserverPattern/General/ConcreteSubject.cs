using System.Collections.Generic;

namespace StrategyPattern.ObserverPattern.General
{
    public class ConcreteSubject:ISubject<int>
    {
        private List<IObserver<int>> observers;
        public int Value { get; set; }
        public void RegisterObserver(IObserver<int> observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver<int> observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver<int> o in observers)
            {
                o.Update(Value);
            }
        }

        public void SetValue(int v)
        {
            Value = v;
            NotifyObservers();
        }
    }
}