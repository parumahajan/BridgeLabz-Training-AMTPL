using System;

namespace BridgeLabz_Training.OOPS.Encapsulation
{
    public class Employee
    {
        // Auto properties
        public int Id { get; set; }
        public string Name { get; set; }

        private double salary;

        // Write-only property (salary can be set but not directly read)
        public double Salary
        {
            set
            {
                if (value >= 10000)
                    salary = value;
                else
                    Console.WriteLine("Salary must be at least 10,000.");
            }
        }

        public void ShowEmployee()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {salary}");
        }
    }
}
