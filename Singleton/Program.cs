using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySuperSingleClass = MySuperSingleClass.GetInstance("First Name");
            Console.WriteLine(mySuperSingleClass.Name);
            mySuperSingleClass = MySuperSingleClass.GetInstance("Second Name");
            Console.WriteLine(mySuperSingleClass.Name);
        }
    }
}