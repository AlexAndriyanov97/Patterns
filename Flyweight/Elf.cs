using System;

namespace Flyweight
{
    public class Elf : Hero
    {
        public override void Create(string name, int age)
        {
            Console.WriteLine($"Created Elf with name is {name}, age: {age}");
        }
    }
}