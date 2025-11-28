using System;
using System.Text.RegularExpressions;
// It gives access to the .NET Regex class.

namespace BridgeLabz_Training.Regex
{
    public class Basics
    {
        public static void Main(String[] args)
        {
            string input = "My number is 8219744409";

            string pattern = @"\d{10}";
            // Used to find sequence of exactly 10 digits

            // We can also write it as: @"\d+"
            // It states: "one or more digits"

            // @ -> "verbatim string literal"

            // It states: "Take the text inside the quotes exactly as I typed it, and don’t treat backslashes '\' or any other escape characters as special."

            // \ -> escape character

            // \d -> digit (0-9)

            // {10} -> exactly 10 digits

            Regex regex = new Regex(pattern);
            // It states: "Create an object of the Regex class using the pattern defined."

            // Regex is a class in the .NET library, derived from the namespace, where it provides methods such as:

            // 1) Matching (Match(), Matches())

            // 2) Replacing (Replace())

            // 3) Checking (IsMatch())

            // 4) Splitting (Split())

            Match match = regex.Match(input);
            // It applies the pattern to the input string, and gives the first match it finds.

            if (match.Success) // boolean property T/F
            {
                Console.WriteLine("Found: " + match.Value);

                // .Value is a built-in property of Match class.
            }
        }
    }
}
/* SYMBOLS

Caret -> ^ -> Start  --> ^Hello 

Dollar -> $ -> End   --> end$

digits -> \d+

n digits -> \d {n}

Atleast n digits

single char -> . --> c.t

0 or one occ  -> ? --> colou?r ---> color, colour
(u* --> u kitni baar repeat hoga)

0 or more occ -> ab*a --> aa, aba, abbba 
(b* --> b kitni baar repeat hoga)

1 or more occ -> + --> a+


 
 */

