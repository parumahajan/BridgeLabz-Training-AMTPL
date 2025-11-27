using System;

namespace BridgeLabz_Training.OOPS.Polymorphism
{
    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks: Woof Woof");
        }
    }
}
