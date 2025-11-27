using System;

namespace BridgeLabz_Training.OOPS.Inheritance.Hierarchical_Inheritance
{
    public class HierarchicalInheritance
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Cow cow = new Cow();

            // Parent class method accessed by all child classes
            dog.Eat();
            dog.Bark();

            Console.WriteLine();

            cat.Eat();
            cat.Meow();

            Console.WriteLine();

            cow.Eat();
            cow.Moo();

            Console.ReadLine();
        }
    }
}
