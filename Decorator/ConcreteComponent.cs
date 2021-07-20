using System;

namespace Decorator
{
    public class ConcreteComponent : Component
    {
        public override void Execute()
        {
            Console.WriteLine($"{nameof(ConcreteComponent)}: Execute Method");
        }
    }
}