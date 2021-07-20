namespace FactoryMethod
{
    public class SecondCreator : Creator
    {
        public override Product Create()
        {
            return new SecondProduct();
        }
    }
}