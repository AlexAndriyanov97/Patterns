using System;

namespace State
{
    public class LiquidState : State
    {
        public void Heat(Water water)
        {
            Console.WriteLine("From Liquid to Gas");
            water.State = new GasState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("From Liquid to Solid");
            water.State = new SolidState();
        }
    }
}