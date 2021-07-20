namespace FactoryMethod
{
    public class FirstCreator : Creator
    {
        public override Product Create()
        {
            return new FirstProduct();
        }
    }
}