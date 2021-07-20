namespace ChainOfResponsibility
{
    public class DogHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            return (request as string) == "Meat" 
                ? $"Dog eat the {request}.\n"
                : base.Handle(request);
        }
    }
}