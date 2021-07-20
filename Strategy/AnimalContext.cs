namespace Patterns
{
    public class AnimalContext
    {
        private IAnimal _animal;

        public AnimalContext(IAnimal animal)
        {
            _animal = animal;
        }

        public void SetStrategy(IAnimal animal)
        {
            _animal = animal;
        }

        public void Voice()
        {
            _animal.Voice();
        }
    }
}