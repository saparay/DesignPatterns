using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern.Product
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
