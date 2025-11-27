using System;

namespace BridgeLabz_Training.OOPS.Inheritance.Single_Inheritance
{
    public class SingleInheritance
    {
        public static void Main(string[] args)
        {
            // Object of derived class
            Employee emp = new Employee();

            // Accessing base class members
            emp.Name = "Pranav";
            emp.Age = 25;

            // Accessing derived class members
            emp.EmployeeId = 1021;
            emp.Salary = 45000;

            // Calling base class method
            emp.ShowDetails();

            // Calling derived class method
            emp.ShowEmployeeInfo();

            Console.ReadLine();
        }
    }
}
