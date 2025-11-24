namespace Task2
{
    class Motorcycle : Vehicle
    {
        // Unique field for Motorcycle
        public string Type { get; set; } // e.g., Sports, Cruiser

        // Constructor
        public Motorcycle(string brand, double speed, string type)
        {
            Brand = brand;
            Speed = speed;
            Type = type;
        }

        // Override DisplayInfo
        public override void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h, Type: {Type}");
        }
    }
}