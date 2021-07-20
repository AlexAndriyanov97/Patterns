using System;

namespace FactoryMethod
{
    public class FirstProduct : Product
    {
        public FirstProduct()
        {
            Console.WriteLine("Product 'A' was created");
        }
    }
}