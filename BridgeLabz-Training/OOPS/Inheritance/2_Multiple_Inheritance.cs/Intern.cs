using System;

namespace BridgeLabz_Training.OOPS.Inheritance.Multiple_Inheritance
{
    public class Intern : IWorker, IStudent   // Multiple inheritance via interfaces
    {
        public string Name;

        public void Work()
        {
            Console.WriteLine($"{Name} is doing office project work.");
        }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying company training materials.");
        }
    }
}
