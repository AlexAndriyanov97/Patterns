using System;

namespace Bridge
{
    public class MinivanCar : ICar
    {
        public void StartEngine()
        {
            Console.WriteLine("Start minivan Engine");
        }

        public void Move()
        {
            Console.WriteLine("Drive a car with a large capacity");
        }
    }
}