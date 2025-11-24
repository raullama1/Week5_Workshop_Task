using System;

namespace Task2
{
    class Vehicle
    {
        // Properties
        public string Brand { get; set; }
        public double Speed { get; set; }

        // Methods
        public void Start()
        {
            Console.WriteLine($"{Brand} started moving at {Speed} km/h.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} has stopped.");
        }

        // Virtual method to allow overriding
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }
}