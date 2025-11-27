using System;

namespace BridgeLabz_Training.OOPS.Inheritance.MultilevelInheritance
{
    public class MultiLevelInheritance
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.Name = "Pranav";
            emp.JobRole = "Software Developer";

            // Methods from different levels
            emp.Breathe();   // From LivingBeing (Level 1)
            emp.Think();     // From Human (Level 2)
            emp.Work();      // From Employee (Level 3)

            Console.ReadLine();
        }
    }
}
