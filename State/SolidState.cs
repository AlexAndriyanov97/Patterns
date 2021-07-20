using System;

namespace State
{
    public class SolidState : State
    {
        public void Heat(Water water)
        {
            Console.WriteLine("From solid to liquid");
            water.State = new LiquidState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Still Solid");
        }
    }
}