using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPerson = new Hero(new FirsHeroFactory());
            firstPerson.SayYourRace();
            firstPerson.Attack();
            Console.WriteLine();
            var secondPerson = new Hero(new SecondHeroFactory());
            secondPerson.SayYourRace();
            secondPerson.Attack();
        }
    }
}