using System;

namespace BridgeLabz_Training.OOPS.Inheritance.HybridInheritance
{
    public class Manager : Employee   // Multilevel continuation
    {
        public string Department;

        public void ManageTeam()
        {
            Console.WriteLine($"{Name} manages the {Department} department.");
        }
    }
}
