using System;
using System.Collections.Generic;

namespace Observer
{
    public class MySuperObservable : IObservable
    {
        private int _mySpecialValue = 0;
        
        private List<IObserver> _observers = new List<IObserver>();
        
        public void Register(IObserver observer)
        {
            Console.WriteLine($"{nameof(MySuperObservable)}: Add observer");
            _observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            Console.WriteLine($"{nameof(MySuperObservable)}: Remove observer");
            _observers.Remove(observer);
        }

        public int GetMySpecialValue()
        {
            return _mySpecialValue;
        }

        public void Notify()
        {
            Console.WriteLine($"{nameof(MySuperObservable)}: Notify observers");
            
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void MySuperBusinessFunction()
        {
            Console.WriteLine("Update value");
            
            _mySpecialValue++;
            
            Notify();
        }
    }
}