namespace AbstractFactory
{
    public class FirsHeroFactory : FactoryOfPersons
    {
        public override Race CreateRace()
        {
            return new Human();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}