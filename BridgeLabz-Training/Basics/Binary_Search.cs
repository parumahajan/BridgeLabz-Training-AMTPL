// For implementing Binary Search, the Array should be in Sorted order (either asc or desc -> MONOTONIC)

using System;
using System.Collections.Generic;

namespace BridgeLabz_Training.Basics;
{
    public class Binary_Search
    {
        public static int BinarySearch(List<int> arr, int key)
        {
            int s = 0;
            int e = arr.Count - 1;

            while (s <= e)
            {

                int mid = s + (e - s) / 2;

                if (arr[mid] == key)
                {
                    return mid;
                }

                else if (key > arr[mid])
                {
                    s = mid + 1;
                }

                else if (key < arr[mid])
                {
                    e = mid - 1;
                }
            }
            return -1;
        }

        public static void Main(string[] args)
        {
            List<int> arr = new List<int> { 11, 22, 33, 44, 55 };

            Console.WriteLine("Enter the value of the key to be searched: ");
            int key = int.Parse(Console.ReadLine()!);

            int index = BinarySearch(arr, key);

            if (index != -1)
            {
                Console.WriteLine("The index at which the key is present is: " + index);
            }
            else
            {
                Console.WriteLine("Key is not present in the array");
            }
        }
    }
}