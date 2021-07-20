using System;

namespace FactoryMethod
{
    public class SecondProduct : Product
    {
        public SecondProduct()
        {
            Console.WriteLine("Product 'B' was created");
        }
    }
}