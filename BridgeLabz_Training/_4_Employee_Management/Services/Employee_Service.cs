using System;
using BridgeLabz_Training._4_Employee_Management.Models;
using BridgeLabz_Training._4_Employee_Management.Interfaces;
using BridgeLabz_Training._4_Employee_Management.Exceptions;

namespace BridgeLabz_Training._4_Employee_Management.Services
{
    public class EmployeeService : IEmployeeService
    {
        private Employee[] employees;   // array to store employees
        private int count = 0;          // how many employees are currently stored
        private const int MaxEmployees = 10; // maximum allowed

        public EmployeeService()
        {
            employees = new Employee[MaxEmployees];
        }

        public void AddEmployee()
        {
            if (count >= MaxEmployees)
            {
                Console.WriteLine("Cannot add more employees. Maximum limit reached (10).");
                return;
            }

            Console.Write("Enter Id (positive integer): ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (ExistsById(id))
            {
                throw new EmployeeAlreadyExistsException("Employee with this Id already exists.");
            }

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            if (ExistsByEmail(email))
            {
                throw new EmployeeAlreadyExistsException("Employee with this Email already exists.");
            }

            Console.Write("Enter Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Employee emp = new Employee(id, name, email, salary);
            employees[count] = emp;
            count++;

            Console.WriteLine("Employee added successfully!");
        }

        public void UpdateEmployee()
        {
            if (count == 0)
            {
                Console.WriteLine("No employees to update.");
                return;
            }

            Console.Write("Enter Id of employee to update: ");
            int id = Convert.ToInt32(Console.ReadLine());

            int index = IndexOfId(id);
            if (index == -1)
            {
                Console.WriteLine("Employee not found.");
                return;
            }

            Employee emp = employees[index];

            Console.WriteLine("Leave input blank to keep current value.");

            Console.Write($"Name ({emp.Name}): ");
            string newName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newName))
            {
                emp.Name = newName;
            }

            Console.Write($"Email ({emp.Email}): ");
            string newEmail = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newEmail))
            {
                if (ExistsByEmail(newEmail))
                {
                    Console.WriteLine("Email already exists. Email not updated.");
                }
                else
                {
                    emp.Email = newEmail;
                }
            }

            Console.Write($"Salary ({emp.Salary}): ");
            string salaryInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(salaryInput))
            {
                double newSalary;
                if (double.TryParse(salaryInput, out newSalary))
                {
                    emp.Salary = newSalary;
                }
                else
                {
                    Console.WriteLine("Invalid salary input. Salary not updated.");
                }
            }

            Console.WriteLine("Employee updated successfully!");
        }

        public void DeleteEmployee()
        {
            if (count == 0)
            {
                Console.WriteLine("No employees to delete.");
                return;
            }

            Console.Write("Enter Id of employee to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            int index = IndexOfId(id);
            if (index == -1)
            {
                throw new EmployeeNotFoundException("Employee with this Id does not exist.");
            }

            // Shift elements left to fill gap
            for (int i = index; i < count - 1; i++)
            {
                employees[i] = employees[i + 1];
            }

            employees[count - 1] = null;
            count--;

            Console.WriteLine("Employee deleted successfully.");
        }

        public void DisplayEmployees()
        {
            if (count == 0)
            {
                Console.WriteLine("No employees to display.");
                return;
            }

            Console.WriteLine("List of Employees:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }

        // ---------------- Helper Methods ----------------

        private bool ExistsById(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        private bool ExistsByEmail(string email)
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].Email.Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private int IndexOfId(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
