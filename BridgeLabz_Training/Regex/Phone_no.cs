using System;
using System.Text.RegularExpressions;

namespace BridgeLabz_Training.Regex
{
    public class Phone_no
    {
        public static void Main(String[] args)
        {
            string input = "My number is 8219744409";
            string pattern = @"\d{10}";

            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            // or Instead of these 2 steps, just write this one single step:

            // Match match = Regex.Match(input, pattern);

            if (match.Success)
            {
                Console.WriteLine("Found: " + match.Value);
            }
            else
            {
                Console.WriteLine("No Match Found");
            }
        }
    }
}