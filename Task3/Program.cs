using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----------- Printer Class -----------\n");
            
            // Polymorphism Part 1: Printer
            Printer printer = new Printer();

            // Call overloaded methods
            printer.Print("Hello World");
            printer.Print(12345);
            printer.Print("Repeat this message", 3);

            Console.WriteLine("\n----------- Teacher Classes -----------\n");

            // Polymorphism Part 2: Teacher
            // Nepali Teacher
            NepaliTeacher nepali = new NepaliTeacher();
            nepali.Name = "Mr. Shrestha";
            Console.WriteLine($"Teacher Name: {nepali.Name}");
            nepali.Teaching();      // Overridden method
            nepali.SalaryInfo();    // Sealed method

            Console.WriteLine();

            // English Teacher
            EnglishTeacher english = new EnglishTeacher();
            english.Name = "Ms. Smith";
            Console.WriteLine($"Teacher Name: {english.Name}");
            english.Teaching();     // Uses base class method
            english.SalaryInfo();   // Sealed method
        }
    }
}