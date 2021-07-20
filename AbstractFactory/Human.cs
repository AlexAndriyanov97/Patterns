using System;

namespace AbstractFactory
{
    public class Human : Race
    {
        public override void GetRace()
        {
            Console.WriteLine("Human");
        }
    }
}