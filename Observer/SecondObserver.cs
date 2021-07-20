using System;

namespace Observer
{
    public class SecondObserver : IObserver
    {
        public void Update(IObservable observable)
        {
            if (((MySuperObservable) observable).GetMySpecialValue() <5)
            {
                Console.WriteLine($"{nameof(SecondObserver)}: ??????");
            }
        }
    }
}