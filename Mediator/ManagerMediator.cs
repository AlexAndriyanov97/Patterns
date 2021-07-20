namespace Mediator
{
    public class ManagerMediator : IMediator
    {
        public FirstExecutor _firstExecutor;
        public SecondExecutor _secondExecutor;

        public void DoSomething(string message, Executor executor)
        {
            if (executor == _firstExecutor)
            {
                _firstExecutor.Print(message);
            }
            else if (executor == _secondExecutor)
            {
                _secondExecutor.Print(message);
            }
        }
    }
}