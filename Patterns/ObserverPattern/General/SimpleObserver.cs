using System;

namespace StrategyPattern.ObserverPattern.General
{
    public class SimpleObserver:IObserver<int>
    {
        private int value;
        private ISubject<int> SimpleSubject { get; set; }

        public SimpleObserver(ISubject<int> ss)
        {
            this.SimpleSubject = ss;
            SimpleSubject.RegisterObserver(this);
        }
        public void Update(int value)
        {
            this.value = value;
        }

        public void Display()
        {
            Console.WriteLine("Value is:"+value);
        }
    }
}