using System;

namespace Flyweight
{
    public class Orc :  Hero
    {
        public override void Create(string name, int age)
        {
            Console.WriteLine($"Created Orc with name is {name}, age: {age}");
        }
    }
}