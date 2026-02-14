using System;
using System.Collections.Generic;
using System.Text;

namespace SynchronizationProxyDesignPattern.BankDemo
{
    public class BankAccountProxy
    {
        private readonly BankAccount _bankAccount;
        private readonly object _lock = new object();

        public BankAccountProxy(decimal initialBalance)
        {
            _bankAccount = new BankAccount(initialBalance);
        }

        public void SafeDeposit(decimal amount)
        {
            lock(_lock)
            {
                _bankAccount.Deposit(amount);
            }
        }

        public void SafeWithdraw(decimal amount)
        {
            lock (_lock)
            {
                _bankAccount.Withdraw(amount);
            }
        }
    }
}
