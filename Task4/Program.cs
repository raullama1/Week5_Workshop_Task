using System;

namespace Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Car object
            Car myCar = new Car();
            Console.WriteLine("CAR:");
            myCar.Display();
            myCar.StartEngine();
            myCar.StopEngine();

            Console.WriteLine();

            // Bike object
            Bike myBike = new Bike();
            Console.WriteLine("BIKE:");
            myBike.Display();
            myBike.StartEngine();
            myBike.StopEngine();
        }
    }
}