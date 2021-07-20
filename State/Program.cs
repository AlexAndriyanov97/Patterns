namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var water = new Water(new LiquidState());
            water.Frost();
            water.Heat();
            water.Heat();
            water.Heat();
        }
    }
}