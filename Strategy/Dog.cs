using System;

namespace Patterns
{
    public class Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine($"{nameof(Dog)} say: GAV");
        }
    }
}