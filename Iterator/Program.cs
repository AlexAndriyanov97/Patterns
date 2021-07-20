using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new CarsCollection();
            collection.AddItem("BMW");
            collection.AddItem("Toyota");
            collection.AddItem("Lexus");
            collection.AddItem("Audi");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
            
            Console.WriteLine();
            
            collection.ReverseDirection();
            
            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }
    }
}