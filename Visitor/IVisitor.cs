namespace Visitor
{
    public interface IVisitor
    {
        void VisitDog(Dog dog);
        void VisitWolf(Wolf wolf);
    }
}