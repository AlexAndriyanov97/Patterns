namespace Bridge
{
    public abstract class Person
    {
        protected ICar Car;

        protected Person(ICar car)
        {
            Car = car;
        }

        public void SetCar(ICar car)
        {
            Car = car;
        }

        public virtual void DoSomething()
        {
            Car.StartEngine();
            Car.Move();
        }

        public abstract void Rest();
    }
}