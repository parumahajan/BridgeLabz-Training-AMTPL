using System;

namespace BridgeLabz_Training.OOPS.Abstraction
{
    public class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike starts using self start or kick start.");
        }

        public override void Stop()
        {
            Console.WriteLine("Bike stops using disc or drum brakes.");
        }
    }
}
