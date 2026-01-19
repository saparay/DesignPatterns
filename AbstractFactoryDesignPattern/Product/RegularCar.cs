using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Product
{
    public class RegularCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching RegularCar Details..");
        }
    }
}
