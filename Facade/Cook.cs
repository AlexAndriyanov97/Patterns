using System;

namespace Facade
{
    public class Cook
    {
        public void PrepareFood()
        {
            Console.WriteLine($"{nameof(Cook)} Prepare Food");
        }
    }
}