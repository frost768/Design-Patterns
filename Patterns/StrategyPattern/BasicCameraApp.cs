using System;
using System.Runtime.InteropServices;

namespace StrategyPattern
{
    public class BasicCameraApp:PhoneCameraApp
    {
       
        public override void Edit()
        {
            Console.WriteLine("This is a PRO feature.");
            Console.WriteLine("Buy CameraPlus to get it.");
        }
    }
}