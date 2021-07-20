using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);
            
            Console.WriteLine(target.SimpleMethod());
        }
    }
}