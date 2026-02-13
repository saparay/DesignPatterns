using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingProxyDesignPattern
{
    public class BankingService : IBankingOperation
    {
        public void TransferFunds(string fromAccount, string toAccount, decimal amount)
        {
            Console.WriteLine($"Transferred {amount: C} from {fromAccount} to {toAccount}");
        }
    }
}
