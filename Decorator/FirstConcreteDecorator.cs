using System;

namespace Decorator
{
    public class FirstConcreteDecorator : Decorator
    {
        public override void Execute()
        {
            base.Execute();
            Console.WriteLine($"{nameof(FirstConcreteDecorator)}: Execute Method");
        }
    }
}