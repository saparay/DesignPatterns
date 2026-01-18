using FactoryMethodDesignPattern.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern.Factory
{
    public class TitaniumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Titanium();
            return product;
        }
    }
}
