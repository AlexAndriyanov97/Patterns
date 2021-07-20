using System;

namespace Mediator
{
    public class SecondExecutor : Executor
    {
        public SecondExecutor(IMediator mediator) 
            : base(mediator)
        { }

        public override void Print(string message)
        {
            Console.WriteLine("Second executor say:" + message);
        }
    }
}