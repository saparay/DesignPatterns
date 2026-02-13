using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingProxyDesignPattern
{
    public class LoggingBankingProxy : IBankingOperation
    {
        private readonly IBankingOperation _bankingOperation;
        private readonly ILogger _logger;

        public LoggingBankingProxy(IBankingOperation bankingOperation, ILogger logger)
        {
            _bankingOperation = bankingOperation;
            _logger = logger;
        }

        public void TransferFunds(string fromAccount, string  toAccount, decimal amount)
        {
            _logger.Log($"Initiating transfer of {amount:C} from {fromAccount} to {toAccount}.");
            _bankingOperation.TransferFunds(fromAccount, toAccount, amount);
            _logger.Log($"Transfer of {amount:C} from {fromAccount} to {toAccount} completed.");
        }
    }
}
