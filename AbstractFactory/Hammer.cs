using System;

namespace AbstractFactory
{
    public class Hammer : Weapon
    {
        public override void Attack()
        {
            Console.WriteLine("Hammer Blow");
        }
    }
}