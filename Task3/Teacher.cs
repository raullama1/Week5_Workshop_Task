using System;

namespace Task3
{
    public class Teacher
    {
        // Property
        public string Name { get; set; }

        // Virtual method: can be overridden
        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English");
        }

        // Sealed method: cannot be overridden
        public void SalaryInfo()
        {
            Console.WriteLine("Salary is fixed and cannot be changed by derived classes.");
        }
    }
}