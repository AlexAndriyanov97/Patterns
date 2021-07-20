using System;

namespace TemplateMethod
{
    public class Dog : AbstractAnimal
    {
        public override void GetName()
        {
            Console.Write($"{nameof(Dog)}: ");
        }

        public override void SecondAction()
        {
            Console.Write("bark");
        }
    }
}