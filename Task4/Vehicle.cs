namespace Task4
{
    public abstract class Vehicle
    {
        // Abstract methods (no body)
        public abstract void StartEngine();
        public abstract void StopEngine();

        // Concrete method (has body)
        public void Display()
        {
            Console.WriteLine("This is a vehicle.");
        }
    }
}