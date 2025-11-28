using System;

namespace BridgeLabz_Training._3_Address_Book_Problem.Utils
{
    public static class Input_Helper
    {
        public static string GetRequiredString(string msg)
        {
            string? s;
            do
            {
                Console.Write($"{msg}: ");
                s = Console.ReadLine()?.Trim();
            } while (string.IsNullOrWhiteSpace(s));
            return s;
        }

        public static string GetOptionalString(string msg)
        {
            Console.Write($"{msg} (Enter to skip): ");
            return Console.ReadLine()?.Trim() ?? "";
        }
    }
}