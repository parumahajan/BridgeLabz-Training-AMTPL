using System;
using System.Collections;

namespace BridgeLabz_Training.Collections
{
    internal class p2_Insert
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            // Adding elements
            al.Add(100);
            al.Add(200);
            al.Add(300);
            al.Add(400);

            // Inserting element at index 3
            al.Insert(3, 350);

            Console.WriteLine("After Insertion:");
            foreach (object obj in al)
                Console.Write(obj + " ");

            Console.WriteLine();

            // Removing element
            al.Remove(350);

            Console.WriteLine("After Deletion:");
            foreach (object obj in al)
                Console.Write(obj + " ");
        }
    }
}
