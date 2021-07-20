namespace AbstractFactory
{
    public class SecondHeroFactory : FactoryOfPersons
    {
        public override Race CreateRace()
        {
            return new Orc();
        }

        public override Weapon CreateWeapon()
        {
            return new Hammer();
        }
    }
}