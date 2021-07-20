namespace AbstractFactory
{
    public abstract class FactoryOfPersons
    {
        public abstract Race CreateRace();
        public abstract Weapon CreateWeapon();
    }
}