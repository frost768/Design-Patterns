using System;
using StrategyPattern.AdapterPattern;
using StrategyPattern.DecoratorPattern;
using StrategyPattern.ObserverPattern;

namespace StrategyPattern
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // BasicCameraApp basicCameraApp= new BasicCameraApp();
            // basicCameraApp.shareBehaviour=new ShareByEmail();
            // basicCameraApp.Share();
            // basicCameraApp.shareBehaviour= new ShareByText();
            // basicCameraApp.Share();
            //
            // Duck mallardDuck= new MallardDuck();
            // mallardDuck.FlyBehaviour= new FlyWithWings();
            // mallardDuck.QuackBehaviour = new QuackBehaviour();
            // mallardDuck.TestDuck();
            // Drone superDrone = new SuperDrone();
            // Duck droneAdapter= new DroneAdapter(superDrone);
            // droneAdapter.Fly();
            // droneAdapter.Quack();
            // WeatherStationSubject weatherStationSubject= new WeatherStationSubject();
            // UserInterface userInterface= new UserInterface();
            // weatherStationSubject.RegisterObserver(userInterface);
            // weatherStationSubject.SetValue(new Report
            // {
            //     Temperature = 12,
            //     Pressure = 13,
            //     WindSpeed = 14
            // });
            
            IPizza thickCrustPizza= new ThickCrustPizza();
            thickCrustPizza = new CheeseTopping(thickCrustPizza);
            thickCrustPizza = new CheeseTopping(thickCrustPizza);
            thickCrustPizza = new CheeseTopping(thickCrustPizza);
            thickCrustPizza = new CheeseTopping(thickCrustPizza);
            Console.WriteLine(thickCrustPizza.Cost());
            Console.WriteLine(thickCrustPizza.getDescription());



        }
    }
}