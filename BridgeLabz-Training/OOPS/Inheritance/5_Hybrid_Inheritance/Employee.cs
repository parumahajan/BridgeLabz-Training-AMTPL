using System;

namespace BridgeLabz_Training.OOPS.Inheritance.HybridInheritance
{
    public class Employee : Person, IWork   // Hybrid: Inheriting class + interface
    {
        public double Salary;

        public void Work()
        {
            Console.WriteLine($"{Name} is working on company tasks.");
        }

        public void ShowEmployee()
        {
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}
