namespace Visitor
{
    public abstract class Animal
    {
        public string AnimalName { get; set; }
        public abstract void Accept(IVisitor visitor);
    }
}