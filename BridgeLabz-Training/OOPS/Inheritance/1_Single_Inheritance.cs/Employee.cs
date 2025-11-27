using System;

namespace BridgeLabz_Training.OOPS.Inheritance.Single_Inheritance
{
    public class Employee : Person   // Single inheritance
    {
        public int EmployeeId;
        public double Salary;

        public void ShowEmployeeInfo()
        {
            // Accessing base class fields
            Console.WriteLine($"Employee ID: {EmployeeId}, Salary: {Salary}");
        }
    }
}
