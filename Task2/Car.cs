namespace Task2
{
    class Car : Vehicle
    {
        // Unique field for Car
        public int Seats { get; set; }

        // Constructor
        public Car(string brand, double speed, int seats)
        {
            Brand = brand;
            Speed = speed;
            Seats = seats;
        }

        // Override DisplayInfo
        public override void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h, Seats: {Seats}");
        }
    }
}