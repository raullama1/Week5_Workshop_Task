using System;

namespace Task5
{
    public class Laptop : ElectronicDevice
    {
        public Laptop(string brand, double price) : base(brand, price)
        {
        }

        // Unique method
        public void TurnOnBattery()
        {
            Console.WriteLine("Laptop battery turned on.");
        }

        // Overriding abstract method
        public override void ShowInfo()
        {
            Console.WriteLine($"Laptop - Brand: {Brand}, Price: {Price}");
        }
    }
}