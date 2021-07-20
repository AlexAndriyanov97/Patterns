using System;

namespace Proxy
{
    public class Bank : IBank
    {
        private int _totalAmount = 0; 
        
        public void PrintTotalAmount()
        {
            Console.WriteLine($"Total amount: {_totalAmount}");
        }

        public void PutMoney(int amount)
        {
            _totalAmount += amount;
        }
    }
}