namespace ChainOfResponsibility
{
    public class CatHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            return (request as string) == "Fish" 
                ? $"Cat eat the {request}.\n"
                : base.Handle(request);
        }
    }
}