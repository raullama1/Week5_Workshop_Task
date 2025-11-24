using System;

namespace Task5
{
    public class ElectronicsStore
    {
        // List to store any electronic devices
        private List<ElectronicDevice> devices = new List<ElectronicDevice>();

        // Add a device to the store
        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
        }

        // Remove a device
        public void RemoveDevice(ElectronicDevice device)
        {
            devices.Remove(device);
        }

        // Show info of all devices
        public void ShowAllDeviceDetails()
        {
            foreach (var device in devices)
            {
                device.ShowInfo();   // Polymorphism

                // Downcasting to call child-specific methods
                if (device is Laptop laptop)
                {
                    laptop.TurnOnBattery();
                }
                else if (device is Smartphone phone)
                {
                    phone.EnableCamera();
                }

                Console.WriteLine(); // spacing
            }
        }
    }
}