namespace AbstractFactory
{
    public class Hero
    {
        private Weapon _weapon;
        private Race _race;

        public Hero(FactoryOfPersons factoryOfPersons)
        {
            _weapon = factoryOfPersons.CreateWeapon();
            _race = factoryOfPersons.CreateRace();
        }

        public void SayYourRace()
        {
            _race.GetRace();
        }

        public void Attack()
        {
            _weapon.Attack();
        }
    }
}