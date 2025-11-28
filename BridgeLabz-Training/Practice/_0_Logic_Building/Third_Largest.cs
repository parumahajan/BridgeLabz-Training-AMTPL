using System;

namespace BridgeLabz_Training.Practice._0_Logic_Building;
{
    internal class Third_Largest
    {
        static void Main()
        {
            int[] arr = { 10, 20, 5, 8, 30 };

            Array.Sort(arr);
            Console.WriteLine(arr[arr.Length - 3]);
        }
    }
}