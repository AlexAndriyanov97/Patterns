namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var restaurantFacade = new RestaurantFacade(new Farmer(), new Cook(), new Waiter());
            restaurantFacade.GetFood();
        }
    }
}