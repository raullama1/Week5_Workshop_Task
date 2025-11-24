using System;

namespace Task5
{
    public abstract class ElectronicDevice
    {
        // Private fields (Encapsulation)
        private string brand;
        private double price;

        // Public properties (with get/set)
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
            }
        }

        // Constructor to initialize brand & price
        public ElectronicDevice(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }

        // Abstract method (must be overridden)
        public abstract void ShowInfo();
    }
}