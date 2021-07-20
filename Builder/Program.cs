using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var constructor = new Constructor();
            HomeBuilder homeBuilder = new PersonHomeBuilder();
            var firstHome = constructor.Build(homeBuilder);
            
            Console.WriteLine(firstHome.ToString());
            
            homeBuilder = new ApartmentHomeBuilder();
            var secondHome = constructor.Build(homeBuilder);
            Console.WriteLine(secondHome.ToString());
        }
    }
}