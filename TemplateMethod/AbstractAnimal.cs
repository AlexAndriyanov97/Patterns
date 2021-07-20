using System;

namespace TemplateMethod
{
    public abstract class AbstractAnimal
    {
        public void TemplateMethod()
        {
            GetName();
            FirstAction();
            Console.Write(" and ");
            SecondAction();
            Console.WriteLine();
        }

        public abstract void GetName();
        public virtual void FirstAction()
        {
            Console.Write("Run");
        }

        public abstract void SecondAction();
    }
}