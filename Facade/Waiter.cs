using System;

namespace Facade
{
    public class Waiter
    {
        public void ServeFood()
        {
            Console.WriteLine($"{nameof(Waiter)} Serve Food");
        }
    }
}