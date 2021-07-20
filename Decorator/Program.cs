namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var concreteComponent = new ConcreteComponent();
            var firstConcreteDecorator = new FirstConcreteDecorator();
            var secondConcreteDecorator = new SecondConcreteDecorate();
            
            firstConcreteDecorator.SetComponent(concreteComponent);
            secondConcreteDecorator.SetComponent(firstConcreteDecorator);
            
            secondConcreteDecorator.Execute();
            
        }
    }
}