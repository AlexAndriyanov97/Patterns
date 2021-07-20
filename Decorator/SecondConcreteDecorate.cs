using System;

namespace Decorator
{
    public class SecondConcreteDecorate : Decorator
    {
        public override void Execute()
        {
            base.Execute();
            Console.WriteLine($"{nameof(SecondConcreteDecorate)}: Execute Method");
        }
    }
}