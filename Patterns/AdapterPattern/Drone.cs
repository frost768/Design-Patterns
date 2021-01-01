using System;

namespace StrategyPattern.AdapterPattern
{
    public interface IDrone
    {
        public void Beep();
        public void SpinRotors();
        public void TakeOff();
    }

    public class Drone:IDrone
    {
        public void Beep()
        {
            Console.WriteLine("Beep beep");
        }

        public void SpinRotors()
        {
            Console.WriteLine("Rotors are spinning");
        }

        public void TakeOff()
        {
            Console.WriteLine("taking off!");
        }
    }

    public class SuperDrone:Drone
    {
        
    }
}