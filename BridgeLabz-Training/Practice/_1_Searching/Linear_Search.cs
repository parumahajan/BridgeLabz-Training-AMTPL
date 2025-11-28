using System;
using System.Collections.Generic;

namespace BridgeLabz_Training.Practice._1_Searching;
{
    public class Linear_Search
    {
        static int LinearSearch(List<int> arr, int key)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void Main(string[] args)
        {
            List<int> arr = new List<int> { 5, 77, 22, 42 };

            Console.WriteLine("Enter the key which needs to be searched: ");
            int key = int.Parse(Console.ReadLine()!);
            // '!' - null-forgiving operator
            // It promises that the value will not be null.
            // Hence, it removes the nullable reference warning.

            int index = LinearSearch(arr, key);

            if (index != -1)
            {
                Console.WriteLine("The key is present at index: " + index);
            }
            else
            {
                Console.WriteLine("The key is not present in the array");
            }
        }
    }
}