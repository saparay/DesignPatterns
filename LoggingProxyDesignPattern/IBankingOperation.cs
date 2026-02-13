using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingProxyDesignPattern
{
    public interface IBankingOperation
    {
        void TransferFunds(string fromAccount, string toAccount, decimal amount);
    }
}
