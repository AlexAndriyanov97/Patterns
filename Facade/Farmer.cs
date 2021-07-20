using System;

namespace Facade
{
    public class Farmer
    {
        public void GrowVegetables()
        {
            Console.WriteLine($"{nameof(Farmer)} Grow Vegetables");
        }

        public void DeliveryVegetables()
        {
            Console.WriteLine($"{nameof(Farmer)} Delivery Vegetables");
        }
    }
}