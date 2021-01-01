using System;

namespace StrategyPattern.ObserverPattern
{
    public class Logger: General.IObserver<Report>
    {
        private Report Report { get; set; }
        public void Update(Report value)
        {
            Report = value;
        }

        public void Log()
        {
            Console.WriteLine("Here is the report:");
            Console.WriteLine($"Temperature:{Report.Temperature}");
            Console.WriteLine($"Pressure:{Report.Pressure}");
            Console.WriteLine($"WindSpeed:{Report.WindSpeed}");
        }
    }
}