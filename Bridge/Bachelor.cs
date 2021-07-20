using System;

namespace Bridge
{
    public class Bachelor : Person
    {
        public Bachelor(ICar car)
            : base(car)
        {
        }

        public override void Rest()
        {
            Console.WriteLine("Drink beer with friends");
        }
    }
}