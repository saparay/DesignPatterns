using AbstractFactoryDesignPattern.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Factory
{
    public class RegularVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new RegularBike();
        }
        public ICar CreateCar()
        {
            return new RegularCar();
        }
    }
}
