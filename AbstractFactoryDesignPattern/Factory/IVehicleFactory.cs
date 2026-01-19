using AbstractFactoryDesignPattern.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Factory
{
    public interface IVehicleFactory
    {
        //Abstract Product A
        IBike CreateBike();
        //Abstract Product B
        ICar CreateCar();
    }
}
