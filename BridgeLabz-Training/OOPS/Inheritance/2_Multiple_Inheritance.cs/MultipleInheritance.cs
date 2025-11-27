using System;

namespace BridgeLabz_Training.OOPS.Inheritance.Multiple_Inheritance
{
    public class MultipleInheritance
    {
        public static void Main(string[] args)
        {
            Intern intern = new Intern();
            intern.Name = "Pranav";

            intern.Work();    // From IWorker interface
            intern.Study();   // From IStudent interface

            Console.ReadLine();
        }
    }
}
