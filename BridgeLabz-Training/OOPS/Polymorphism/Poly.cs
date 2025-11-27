using System;

namespace BridgeLabz_Training.OOPS.Polymorphism
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // ----------------- Compile-time Polymorphism: Method Overloading -----------------
            MathOperations math = new MathOperations();
            Console.WriteLine("Add(2, 3) = " + math.Add(2, 3));
            Console.WriteLine("Add(1, 2, 3) = " + math.Add(1, 2, 3));
            Console.WriteLine("Add(2.5, 3.5) = " + math.Add(2.5, 3.5));
            Console.WriteLine();

            // ----------------- Compile-time Polymorphism: Operator Overloading -----------------
            Vector v1 = new Vector(2, 3);
            Vector v2 = new Vector(4, 5);
            Vector v3 = v1 + v2;
            Console.WriteLine($"Vector Sum = ({v3.X}, {v3.Y})");
            Console.WriteLine();

            // ----------------- Runtime Polymorphism: Method Overriding -----------------
            Animal animal;

            animal = new Dog();
            animal.Speak();

            animal = new Cat();
            animal.Speak();

            Console.ReadLine();
        }
    }
}
