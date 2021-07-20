namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankProxy = new BankProxy();
            bankProxy.PutMoney(300);
            bankProxy.PrintTotalAmount();
        }
    }
}