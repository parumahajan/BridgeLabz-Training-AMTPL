using System;

namespace BridgeLabz_Training.OOPS.Inheritance.Single_Inheritance
{
    public class Person
    {
        public string Name;
        public int Age;

        public void ShowDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
