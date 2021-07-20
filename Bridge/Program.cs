namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bachelor = new Bachelor(new MinivanCar());
            bachelor.DoSomething();
            bachelor.SetCar(new SedanCar());
            bachelor.DoSomething();
            bachelor.Rest();
        }
    }
}