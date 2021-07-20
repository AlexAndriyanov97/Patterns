using System;

namespace AbstractFactory
{
    public class Sword : Weapon
    {
        public override void Attack()
        {
            Console.WriteLine("Sword strike");
        }
    }
}