namespace Visitor
{
    public class Wolf : Animal
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitWolf(this);
        }
    }
}