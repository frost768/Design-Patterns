using System;

namespace StrategyPattern
{
    public class CameraPlus:PhoneCameraApp
    {
        public override void Edit()
        {
            Console.WriteLine("Editing...");
        }
    }
}