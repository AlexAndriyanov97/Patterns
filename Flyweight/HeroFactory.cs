using System.Collections.Generic;

namespace Flyweight
{
    public class HeroFactory
    {
        private Dictionary<string, Hero> _heroes = new Dictionary<string, Hero>();

        public HeroFactory()
        {
            _heroes.Add("Elf", new Elf());
            _heroes.Add("Human", new Human());
            _heroes.Add("Orc", new Orc());
        }

        public Hero GetHero(string race)
        {
            if (_heroes.ContainsKey(race))
            {
                return _heroes[race];
            }
            return null;
        }
    }
}