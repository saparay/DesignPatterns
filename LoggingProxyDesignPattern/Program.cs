namespace LoggingProxyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBankingOperation bankingService = new BankingService();
            ILogger logger = new ConsoleLogger();
            IBankingOperation proxyBankingService = new LoggingBankingProxy(bankingService, logger);

            proxyBankingService.TransferFunds("AccountA", "AccountB", 1000m);
            Console.ReadKey();
        }
    }
}
