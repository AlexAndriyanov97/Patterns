using System;

namespace TemplateMethod
{
    public class Wolf : AbstractAnimal
    {
        public override void GetName()
        {
            Console.Write($"{nameof(Wolf)}: ");
        }

        public override void SecondAction()
        {
            Console.Write("Kus'");
        }
    }
}