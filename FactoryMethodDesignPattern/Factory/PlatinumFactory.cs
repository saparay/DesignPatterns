using FactoryMethodDesignPattern.Factory;
using FactoryMethodDesignPattern.Product;

namespace FactoryMethodDesignPattern
{
    // PlatinumFactory Concrete Creators override the factory MakeProduct method
    // to create and return the Platinum Product
    public class PlatinumFactory : CreditCardFactory
    {
        // The signature of the method uses the abstract product CreditCard type,
        // Even though the concrete Platinum product is returned from the method.
        // This way the Abstract Creator CreditCardFactory can stay independent of concrete product classes.
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Platinum();
            return product;
        }
    }
}