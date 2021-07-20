namespace Facade
{
    public class RestaurantFacade
    {
        private readonly Farmer _farmer;
        private readonly Cook _cook;
        private readonly Waiter _waiter;

        public RestaurantFacade(Farmer farmer, Cook cook, Waiter waiter)
        {
            _farmer = farmer;
            _cook = cook;
            _waiter = waiter;
        }

        public void GetFood()
        {
            _farmer.GrowVegetables();
            _farmer.DeliveryVegetables();
            _cook.PrepareFood();
            _waiter.ServeFood();
        }
    }
}