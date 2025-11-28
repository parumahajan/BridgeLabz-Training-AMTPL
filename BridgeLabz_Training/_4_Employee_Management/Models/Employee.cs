using System;

namespace BridgeLabz_Training._4_Employee_Management.Models
{
    public class Employee
    {
        // Private
        private int id;
        private string name;
        private string email;
        private double salary;

        // Public
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        // Constructor
        public Employee(int id, string name, string email, double salary)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.salary = salary;
        }

        // Display
        public void DisplayEmployee()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Email: {Email}, Salary: {Salary}");
        }
    }
}