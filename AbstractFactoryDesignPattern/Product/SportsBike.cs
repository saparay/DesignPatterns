using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Product
{
    public class SportsBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching SportsBike Details..");
        }
    }
}
