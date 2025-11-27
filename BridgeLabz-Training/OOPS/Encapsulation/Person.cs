using System;

namespace BridgeLabz_Training.OOPS.Encapsulation
{
    public class Person // DEFINES BEHAVIOUR
    {
        private string name; // PRIVATE VARIABLE

        public string Name // PROPERTY
        {
            get { return name; }

            set { name = value; }

            // OR (Auto-Implemented Properties)
            // public string Name { get; set; }
        }

        public Person(string name)
        {
            this.name = name;
        }
    }
}