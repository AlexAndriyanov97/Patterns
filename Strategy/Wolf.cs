using System;

namespace Patterns
{
    public class Wolf : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine($"{nameof(Wolf)} say: AUF");
        }
    }
}