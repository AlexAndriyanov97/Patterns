using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            var wolf = new Wolf();
            
            dog.TemplateMethod();
            wolf.TemplateMethod();
        }
    }
}