using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Product
{
    public class SportsCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching SportsCar Details..");
        }
    }
}
