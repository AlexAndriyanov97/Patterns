using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public class User
    {
        public void Feed(AbstractHandler handler)
        {
            foreach (var food in new List<string> { "Fish", "Meat", "Сheese", "SCHAURMA" })
            {
                Console.WriteLine($"User: Who wants a {food}?");
                var result = handler.Handle(food);
                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {food} was left untouched.");
                }
            }
        }
    }
}