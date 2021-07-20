using System;

namespace Visitor
{
    public class AnimalVisitor : IVisitor
    {
        public void VisitDog(Dog dog)
        {
            Console.WriteLine($"Dog name is {dog.AnimalName}");
        }

        public void VisitWolf(Wolf wolf)
        {
            Console.WriteLine($"Wolf name is {wolf.AnimalName}");
        }
    }
}