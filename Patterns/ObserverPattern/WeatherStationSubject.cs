using System.Collections.Generic;
using StrategyPattern.ObserverPattern.General;

namespace StrategyPattern.ObserverPattern
{
    public class WeatherStationSubject:ISubject<Report>
    {
        private List<IObserver<Report>> observers= new List<IObserver<Report>>();
        public Report Report { get; set; }
        public void RegisterObserver(IObserver<Report> observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver<Report> observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver<Report> o in observers)
            {
                o.Update(Report);
            }
        }

        public void SetValue(Report r)
        {
            Report = r;
            NotifyObservers();
        }
    }
}