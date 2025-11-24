// Derived Class: Bike
using System;

namespace Task4
{
    public class Bike : Vehicle
    {
        // StartEngine() from abstract class
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started.");
        }

        // StopEngine() from abstract class
        public override void StopEngine()
        {
            Console.WriteLine("Bike engine stopped.");
        }
    }
}