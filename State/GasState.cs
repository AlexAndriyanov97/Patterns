using System;

namespace State
{
    public class GasState : State
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Still Gas state");
        }

        public void Frost(Water water)
        {
            Console.WriteLine("From Gas to liquid");
            water.State = new LiquidState();
        }
    }
}