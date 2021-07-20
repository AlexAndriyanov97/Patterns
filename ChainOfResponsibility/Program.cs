using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new DogHandler();
            var cat = new CatHandler();
            var mouse = new MouseHandler();

            dog.SetNext(cat).SetNext(mouse);
            var user = new User();
            user.Feed(dog);
            
            Console.WriteLine();
            user.Feed(cat);
            
        }
    }
}