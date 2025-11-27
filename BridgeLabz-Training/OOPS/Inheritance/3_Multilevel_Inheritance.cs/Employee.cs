using System;

namespace BridgeLabz_Training.OOPS.Inheritance.Multilevel_Inheritance
{
    public class Employee : Human    // Level 3 inheritance
    {
        public string Name;
        public string JobRole;

        public void Work()
        {
            Console.WriteLine($"{Name} is working as a {JobRole}.");
        }
    }
}
