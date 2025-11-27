using System;

namespace BridgeLabz_Training.OOPS.Abstraction
{
    // Abstract class - you cannot create object of this class
    public abstract class Vehicle
    {
        // Abstract method (no body)
        public abstract void Start();

        // Abstract method
        public abstract void Stop();

        // Non-abstract / Concrete method (optional)
        public void DisplayInfo()
        {
            Console.WriteLine("Every vehicle has an engine and wheels.");
        }
    }
}
``
