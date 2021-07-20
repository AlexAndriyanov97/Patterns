namespace Proxy
{
    public class BankProxy : IBank
    {
        private readonly Bank _bank = new Bank();
        
        public void PrintTotalAmount()
        {
            _bank.PrintTotalAmount();
        }

        public void PutMoney(int amount)
        {
            _bank.PutMoney(amount);
        }
    }
}