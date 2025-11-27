using System;

namespace BridgeLabz_Training.OOPS.Inheritance.HybridInheritance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Manager mgr = new Manager();

            // Base class fields
            mgr.Name = "Pranav";
            mgr.Age = 28;

            // Employee-level field
            mgr.Salary = 75000;

            // Manager-level field
            mgr.Department = "Software Development";

            // Method calls from different inheritance levels
            mgr.ShowPerson();     // From Person
            mgr.ShowEmployee();   // From Employee
            mgr.Work();           // From IWork Interface
            mgr.ManageTeam();     // From Manager

            Console.ReadLine();
        }
    }
}
