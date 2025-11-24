using System;

namespace Task3
{
   public class Printer
    {
        // Method 1: Print string
        public void Print(string message)
        {
            Console.WriteLine($"Message: {message}");
        }

        // Method 2: Print integer
        public void Print(int number)
        {
            Console.WriteLine($"Number: {number}");
        }

        // Method 3: Print string multiple times
        public void Print(string message, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Message {i + 1}: {message}");
            }
        }
    }
}