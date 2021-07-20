namespace Mediator
{
    public abstract class Executor
    {
        protected IMediator _mediator;

        protected Executor(IMediator mediator)
        {
            _mediator = mediator;
        }

        public virtual void Execute(string message)
        {
            _mediator.DoSomething(message, this);
        }

        public abstract void Print(string message);
    }
}