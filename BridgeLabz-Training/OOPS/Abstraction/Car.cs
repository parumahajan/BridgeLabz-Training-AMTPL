using System;

namespace BridgeLabz_Training.OOPS.Abstraction
{
    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car starts using a key or push button.");
        }

        public override void Stop()
        {
            Console.WriteLine("Car stops using hydraulic brakes.");
        }
    }
}
