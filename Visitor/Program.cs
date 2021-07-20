using System.Collections.Generic;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfAnimal = new List<Animal>();
            listOfAnimal.Add(new Dog{ AnimalName = "Bobik"});
            listOfAnimal.Add(new Dog{ AnimalName = "Muhtar"});
            listOfAnimal.Add(new Wolf{ AnimalName = "Petr"});
            listOfAnimal.Add(new Wolf{ AnimalName = "Oleg"});
            var visitor = new AnimalVisitor();
            foreach (var animal in listOfAnimal)
            {
                animal.Accept(visitor);
            }
        }
    }
}