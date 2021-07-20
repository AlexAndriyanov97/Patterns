using System;

namespace Bridge
{
    public class FamilyGuy : Person
    {
        public FamilyGuy(ICar car) : base(car)
        {
        }

        public override void Rest()
        {
            Console.WriteLine("Spending time with family");
        }
    }
}