namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySuperObservable = new MySuperObservable();
            var firstObserver = new FirstObserver();
            mySuperObservable.Register(firstObserver);

            var secondObserver = new SecondObserver();
            mySuperObservable.Register(secondObserver);
            
            mySuperObservable.MySuperBusinessFunction();
            mySuperObservable.MySuperBusinessFunction();
            mySuperObservable.Remove(firstObserver);
            mySuperObservable.MySuperBusinessFunction();
        }
    }
}