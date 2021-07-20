namespace Decorator
{
    public abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }
        
        public override void Execute()
        {
            component?.Execute();
        }
    }
}