using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameList = new List<string>()
            {
                "Alex",
                "Bob",
                "John",
                "Sam",
                "Oleg"
            };
            
            var heroFactory = new HeroFactory();
            var age = 20;
            for (var i = 0; i < 5; i++)
            {
                var hero = heroFactory.GetHero("Human");
                if (hero != null)
                {
                    hero.Create(nameList[i], age);
                }
                age++;
            }
            
            age = 50;
            for (var i = 0; i < 5; i++)
            {
                var hero = heroFactory.GetHero("Orc");
                if (hero != null)
                {
                    hero.Create(nameList[i], age);
                }
                age++;
            }
            
            age = 200;
            for (var i = 0; i < 5; i++)
            {
                var hero = heroFactory.GetHero("Elf");
                if (hero != null)
                {
                    hero.Create(nameList[i], age);
                }
                age++;
            }
        }
    }
}