namespace Visitor
{
    public class Dog : Animal
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitDog(this);
        }
    }
}