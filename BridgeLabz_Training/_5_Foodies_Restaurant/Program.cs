using System;

namespace BridgeLabz_Training._5_Foodies_Restaurant
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Banking System\n");

            Details person1 = new Details("John Doe", 5000.00);
            Details person2 = new Details("Jane Smith", 10000.00);
            Details person3 = new Details("David Miller", 7500.00);

            person1.Display();
            person2.Display();
            person3.Display();

            Console.WriteLine("\n Welcome to Foodies Restaurant\n");

            Console.WriteLine("Here's today menu: \n");

            Console.WriteLine("Margherita Pizza - 299.50");

            Console.WriteLine("Paneer Butter Masala - 249.00");

            Console.WriteLine("Cold Coffee - 99.00\n");

            Console.WriteLine("Total Bill: 647.50\n");

            Console.WriteLine("Thank you for dining with us!");
        }
    }
}