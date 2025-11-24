using System;

namespace Task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create store object
            ElectronicsStore store = new ElectronicsStore();

            // Create devices
            Laptop laptop = new Laptop("Dell", 1200);
            Smartphone phone = new Smartphone("Samsung", 900);

            // Add devices to store
            store.AddDevice(laptop);
            store.AddDevice(phone);

            // Display all device details + behaviors
            store.ShowAllDeviceDetails();
        }
    }
}