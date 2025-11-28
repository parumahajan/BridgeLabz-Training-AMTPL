using System;

namespace BridgeLabz_Training._5_Foodies_Restaurant
{
    public class Details
    {
        private static int starting_account_no = 1000;

        private int account_no;
        private string name;
        private double balance;

        public int Account_No
        {
            get { return account_no; }
            set { account_no = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Details(string name, double balance)
        {
            Account_No = starting_account_no++;
            Name = name;
            Balance = balance;
        }

        public void Display()
        {
            Console.WriteLine("Account_No: " + Account_No + ", Name: " + Name + ", Balance: " + Balance);
        }
    }
}