namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ManagerMediator();
            var firstExecutor = new FirstExecutor(mediator);
            var secondExecutor = new SecondExecutor(mediator);
            mediator._firstExecutor = firstExecutor;
            mediator._secondExecutor = secondExecutor;
            
            firstExecutor.Print("I am first");
            secondExecutor.Print("I am second");
        }
    }
}