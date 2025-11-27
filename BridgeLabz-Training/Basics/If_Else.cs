// Using if-statements to check if the number is less than a specific number or not.

using System;
namespace DSA
{
    public class B1_If_St
    {
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            if (a < 20)
            {

                // STRING CONCATENATION
                Console.WriteLine("a: " + a);

                // STRING INTERPOLATION
                Console.WriteLine($"a: {a}");

                // STRING FORMATTING (using placeholder {})
                Console.WriteLine("a: {0}, b: {1}", a, b);
            }
        }
    }
}