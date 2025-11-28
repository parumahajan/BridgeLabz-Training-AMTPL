using System;

namespace BridgeLabz_Training.Exceptions
{
    public class Basics
    {
        public static void Main(String[] args)
        {
            try
            {
                int[] arr = { 1, 2, 3 };
                Console.WriteLine(arr[5]);
                // Index out of Range Exception
            }
            catch (IndexOutOfRangeException ex)
            // ex is the variable, where the exception object is stored.
            {
                Console.WriteLine("Error: " + ex.Message);
                // ".Message" is a predefined property of Exception class.
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
        }
    }
}


/*
  DivideByZeroException

  OverflowException 
value exceeds the range of its data type

  IndexOutOfRangeException 
Accessing an array or collection element outside its valid index.

  ArgumentOutOfRangeException 
thrown when the method argument is outside the allowable range of values.

 KeyNotFoundException
thrown when a key does not exist in a dictionary or collection.
 
 IOException
General I/O error (e.g., file access issues).
 
FormatException
When you try to convert a string into another type but the string is not in the correct format

string input = "abc";
int num = int.Parse(input);  // ❌ FormatException
*/

try
{
    int[] arr = { 1, 2, 3 };
    Console.WriteLine(arr[5]);
}

catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
finally
{
    Console.WriteLine("Finally block executed");
}