using System;

namespace Task4
{
    class Car : Vehicle
    {
        // StartEngine() from abstract class
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }

        // StopEngine() from abstract class
        public override void StopEngine()
        {
            Console.WriteLine("Car engine stopped.");
        }
    }
}