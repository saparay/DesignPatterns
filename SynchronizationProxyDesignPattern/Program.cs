using SynchronizationProxyDesignPattern.BankDemo;

namespace SynchronizationProxyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrinterProxy proxy = new PrinterProxy();

            Task.Run(() => proxy.Print("Document A"));
            Task.Run(() => proxy.Print("Document B"));
            Task.Run(() => proxy.Print("Document C"));
            Console.ReadKey();


            // Bank Acccount Example 

            BankAccountProxy accountProxy = new BankAccountProxy(1000);

            Task.Run(() => accountProxy.SafeDeposit(200));
            Task.Run(() => accountProxy.SafeWithdraw(500));
            Task.Run(() => accountProxy.SafeDeposit(300));
            Task.Run(() => accountProxy.SafeWithdraw(150));
            Console.ReadKey();
        }
    }
}
