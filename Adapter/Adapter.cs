namespace Adapter
{
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string SimpleMethod()
        {
            return _adaptee.MySuperSpecialMethod();
        }
    }
}