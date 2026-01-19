using AbstractFactoryDesignPattern.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Factory
{
    public class SportsVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new SportsBike();
        }
        public ICar CreateCar()
        {
            return new SportsCar();
        }
    }
}
