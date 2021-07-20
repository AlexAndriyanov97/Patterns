using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new FirstCreator();
            var firstProduct = creator.Create();

            creator = new SecondCreator();
            var secondProduct = creator.Create();
        }
    }
}