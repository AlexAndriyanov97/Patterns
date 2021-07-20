namespace ChainOfResponsibility
{
    public class MouseHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            return (request as string) == "Сheese" 
                ? $"Mouse eat the {request}.\n"
                : base.Handle(request);
        }
    }
}