using System;

namespace AbstractFactory
{
    public class Orc : Race
    {
        public override void GetRace()
        {
            Console.WriteLine("Orc");
        }
    }
}