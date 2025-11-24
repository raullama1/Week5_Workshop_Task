using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car object
            Car myCar = new Car("Toyota", 120, 5);
            myCar.Start();
            myCar.DisplayInfo();
            myCar.Stop();

            Console.WriteLine();

            // Motorcycle object
            Motorcycle myBike = new Motorcycle("Honda", 100, "Sports");
            myBike.Start();
            myBike.DisplayInfo();
            myBike.Stop();
        }
    }
}