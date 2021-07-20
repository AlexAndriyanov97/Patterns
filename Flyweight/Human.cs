using System;

namespace Flyweight
{
    public class Human : Hero
    {
        public override void Create(string name, int age)
        {
            Console.WriteLine($"Created Human with name is {name}, age: {age}");
        }
    }
}