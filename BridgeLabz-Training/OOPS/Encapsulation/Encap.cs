using System;

namespace BridgeLabz_Training.OOPS.Encapsulation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // ----------------- Student (Getter/Setter Methods) -----------------
            Student s = new Student();
            s.SetName("Pranav");
            s.SetAge(21);
            Console.WriteLine("Student Name: " + s.GetName());
            Console.WriteLine("Student Age: " + s.GetAge());
            Console.WriteLine();

            // ----------------- BankAccount (Properties with validation) -----------------
            BankAccount account = new BankAccount(5000);
            account.Deposit(2000);
            account.Withdraw(1500);
            Console.WriteLine("Current Account Balance: " + account.Balance);
            Console.WriteLine();

            // ----------------- Employee (Auto + Write-only property) -----------------
            Employee emp = new Employee();
            emp.Id = 101;
            emp.Name = "John";
            emp.Salary = 30000; // write-only property
            emp.ShowEmployee();

            Console.ReadLine();
        }
    }
}
