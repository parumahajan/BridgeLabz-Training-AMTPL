using System;

namespace BridgeLabz_Training.OOPS.Abstraction
{
    public class Abstract
    {
        public static void Main(string[] args)
        {
            Vehicle v;

            v = new Car();
            v.DisplayInfo();
            v.Start();
            v.Stop();
            Console.WriteLine();

            v = new Bike();
            v.DisplayInfo();
            v.Start();
            v.Stop();
            Console.WriteLine();

            v = new ElectricScooter();
            v.DisplayInfo();
            v.Start();
            v.Stop();

            Console.ReadLine();
        }
    }
}
