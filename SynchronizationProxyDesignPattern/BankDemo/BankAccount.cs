using System;
using System.Collections.Generic;
using System.Text;

namespace SynchronizationProxyDesignPattern.BankDemo
{
    public class BankAccount
    {
        private decimal _balance;

        public BankAccount(decimal initialBalance)
        {
            _balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Depositing: ${amount}");
            _balance += amount;
            Console.WriteLine($"New Balance: ${_balance}");
        }

        public void Withdraw(decimal amount)
        {
            if (_balance >= amount)
            {
                Console.WriteLine($"Withdrawing: ${amount}");
                _balance -= amount;
                Console.WriteLine($"New Balance: ${_balance}");
            }
            else
            {
                Console.WriteLine($"Insufficient funds. Current Balance: ${_balance}");
            }
        }
    }
}
