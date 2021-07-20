namespace Mediator
{
    public interface IMediator
    {
        void DoSomething(string message, Executor executor);
    }
}