using System;

namespace BridgeLabz_Training.OOPS.Encapsulation
{
    public class BankAccount
    {
        private double balance;

        // Manual Property with validation
        public double Balance
        {
            get { return balance; }
            private set        // private setter → read-only from outside
            {
                if (value >= 0)
                    balance = value;
                else
                    Console.WriteLine("Balance cannot be negative.");
            }
        }

        public BankAccount(double initialAmount)
        {
            Balance = initialAmount;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
                Balance = Balance + amount;
            else
                Console.WriteLine("Deposit amount must be positive.");
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
                Balance = Balance - amount;
            else
                Console.WriteLine("Insufficient funds.");
        }
    }
}
