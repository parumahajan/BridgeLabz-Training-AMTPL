// Code to test the AUTO-RESIZING feature of Collections

using System;
using System.Collections;

namespace namespace BridgeLabz_Training.Collections;
{
    public class p1_Auto_Resize
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            //default constructor (without parameter)

            Console.WriteLine(al.Capacity);
            //It will print the number of items elements the ArrayList can hold before resizing

            //Right now, the Capacity = 0

            al.Add(100);
            //Now, the Capacity = 4

            //It is allocating the room to store 4 items at a time (instead of allocating 1-1 item each).

            //Hence, the elt 100 will be stored at one of the positions (starting), of those 4 spaces which are allocated.

            //And suppose, we add 3 more elts, and those 4 items gets filled too, then the capacity doubles, and becomes 8, and keeps going on...4 -> 8 -> 16 -> 32 ...

            //HENCE,CAPACITY GETS DOUBLED AUTOMATICALLY 


            //While creating the ArrayList, we can also pass the Parameters.
            // Eg: ArrayList al = new ArrayList(5);


            foreach (object obj in al)
                Console.WriteLine(obj + " ");
            //This will print the element present inside the collection

            //It automatically goes one by one through all items in the collection, without you needing to use indexes

            //Declares a variable named 'obj' which will temporarily hold each element from the collection

            //in al -> Takes each element from the collection al(ArrayList)”

            Console.ReadLine();
        }
    }
}