using System;

namespace Observer
{
    public class FirstObserver : IObserver
    {
        public void Update(IObservable observable)
        {
            if (((MySuperObservable) observable).GetMySpecialValue() <7)
            {
                Console.WriteLine($"{nameof(FirstObserver)}: !!!!!!");
            }
        }
    }
}