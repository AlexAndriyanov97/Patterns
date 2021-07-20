using System;

namespace Bridge
{
    public class SedanCar : ICar
    {
        public void StartEngine()
        {
            Console.WriteLine("Start Sedan Engine");
        }

        public void Move()
        {
            Console.WriteLine("Drive by car with high speed");
        }
    }
}