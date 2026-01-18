using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
