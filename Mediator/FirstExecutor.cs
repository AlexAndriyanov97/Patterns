
using System;

namespace Mediator
{
    public class FirstExecutor : Executor
    {
        public FirstExecutor(IMediator mediator) 
            : base(mediator)
        { }

        public override void Print(string message)
        {
            Console.WriteLine("First Executor Say:" + message);
        }
    }
}