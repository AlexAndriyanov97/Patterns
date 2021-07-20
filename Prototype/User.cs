using System;

namespace Prototype
{
    public class User : UserPrototype
    {
        public string SecondName;
        public string FirstName;
        public int Age;

        public User(string firstName, string secondName, int age)
        {
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
        }

        public override UserPrototype Clone()
        {
            Console.WriteLine($"Cloning User: {FirstName} {SecondName} {Age}");
            
            return MemberwiseClone() as UserPrototype;
        }

        public override string ToString()
        {
            return $"User: {FirstName} {SecondName} {Age}";
        }
    }
}