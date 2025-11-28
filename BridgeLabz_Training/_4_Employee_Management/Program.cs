using System;
using BridgeLabz_Training._4_Employee_Management.Interfaces;
using BridgeLabz_Training._4_Employee_Management.Services;
using BridgeLabz_Training._4_Employee_Management.Exceptions;

namespace BridgeLabz_Training._4_Employee_Management.Services
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IEmployeeService service = new EmployeeService();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("=== Employee Management System ===");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Update Employee");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4. Display Employees");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option (1-5): ");

                string? choice = Console.ReadLine();
                Console.WriteLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            service.AddEmployee();
                            break;
                        case "2":
                            service.UpdateEmployee();
                            break;
                        case "3":
                            service.DeleteEmployee();
                            break;
                        case "4":
                            service.DisplayEmployees();
                            break;
                        case "5":
                            Console.WriteLine("Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }
                }
                catch (EmployeeAlreadyExistsException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"❌ {ex.Message}");
                    Console.ResetColor();
                }
                catch (EmployeeNotFoundException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"⚠️ {ex.Message}");
                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                    Console.ResetColor();
                }
            }
        }
    }
}