using System;
using System.Collections.Generic;

namespace BridgeLabz_Training.Practice._2_Sorting;
{
    public class Merge_Sort
    {
        static void Merge(List<int> arr, int s, int mid, int e)
        // we made it static, since our Main class is also static,

        // and a static method can only call a static method.
        {
            List<int> temp = new List<int>();
            // 'temp' (temporary list) will store the sorted elements

            int i = s;       // left half index         
            int j = mid + 1; // right half index

            // Merge 2 sorted halves
            while (i <= mid && j <= e)
            // (i -> s to mid) && (j -> mid+1 to e)
            {
                // If left element is smaller, add it to temp
                if (arr[i] <= arr[j])
                {
                    temp.Add(arr[i]);
                    i++;
                }
                // If right element is smaller, add it to temp
                else
                {
                    temp.Add(arr[j]);
                    j++;
                }
            }

            // ------------------------------------------------
            // Add remaining elements from left half
            while (i <= mid)
            {
                temp.Add(arr[i]);
                i++;
            }

            // Add remaining elements from right half
            while (j <= e)
            {
                temp.Add(arr[j]);
                j++;
            }

            // ------------------------------------------------
            // Copy all sorted values from temp back into original arr (starting from index `s`)
            for (int k = 0; k < temp.Count; k++)
            {
                arr[s + k] = temp[k];
            }
        }

        // ----------------------------------------------------
        static void MergeSort(List<int> arr, int s, int e)
        {
            if (s >= e) // Base condition for stopping
                return;

            int mid = s + (e - s) / 2;

            MergeSort(arr, s, mid);
            MergeSort(arr, mid + 1, e);

            Merge(arr, s, mid, e);
        }

        // ----------------------------------------------------
        public static void Main(string[] args)
        {
            List<int> arr = new List<int> { 12, 31, 35, 8, 32, 17 };

            MergeSort(arr, 0, arr.Count - 1);

            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
        }
    }
}