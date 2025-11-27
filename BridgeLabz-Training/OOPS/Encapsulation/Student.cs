using System;

namespace BridgeLabz_Training.OOPS.Encapsulation
{
    public class Student
    {
        private string name;
        private int age;

        // Getter method
        public string GetName()
        {
            return name;
        }

        // Setter method with validation
        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
                Console.WriteLine("Name cannot be empty.");
            else
                this.name = name;
        }

        // Getter & Setter for age
        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            if (age < 0)
                Console.WriteLine("Age cannot be negative.");
            else
                this.age = age;
        }
    }
}
