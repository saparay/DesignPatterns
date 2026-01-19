using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Product
{
    public class RegularBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching RegularBike Details..");
        }
    }
}
