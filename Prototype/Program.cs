using System;
using System.Collections.Generic;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var userList = new List<User>()
            {
                new User("Alex", "Alex", 23),
                new User("John", "John", 40),
                new User("Logan", "Logan", 50),
            };
            
            Console.WriteLine(userList[0].ToString());
            Console.WriteLine(userList[1].ToString());
            Console.WriteLine(userList[2].ToString());

            Console.WriteLine();
            
            var firstCopiedUser = userList[0].Clone() as User;
            var secondCopiedUser = userList[1].Clone() as User;
            var thirdCopiedUser = userList[2].Clone() as User;
            
            Console.WriteLine();
            
            Console.WriteLine(firstCopiedUser?.ToString());
            Console.WriteLine(secondCopiedUser?.ToString());
            Console.WriteLine(thirdCopiedUser?.ToString());
        }
    }
}