namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalContext = new AnimalContext(new Dog());
            animalContext.Voice();
            
            animalContext.SetStrategy(new Wolf());
            animalContext.Voice();
        }
    }
}