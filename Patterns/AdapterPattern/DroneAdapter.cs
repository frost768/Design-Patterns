using System;

namespace StrategyPattern.AdapterPattern
{
    public class DroneAdapter:Duck
    {
        Drone Drone { get; set; }
        public DroneAdapter(Drone drone)
        {
            Drone = drone;
        }
        

        public override void Display()
        {
            Console.WriteLine("I am a drone");
        }

     
    }
}