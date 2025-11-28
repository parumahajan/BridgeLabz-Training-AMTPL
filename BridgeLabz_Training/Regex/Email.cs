using System;
using System.Text.RegularExpressions;

namespace BridgeLabz_Training.Regex
{
    public class Email
    {
        public static void Main(String[] args)
        {
            string input = "pranavmahajan619@gmail.com";

            string pattern = @"\w+@\w+\.\w+";

            Regex regex = new Regex(pattern);

            Match match = regex.Match(input);

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

string input 
string pattern

Regex regex = new Regex();
Match match = Regex.