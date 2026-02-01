using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace DecoratorDesignPattern
{
    public class DieselCarDecorator : CarDecorator
    {
        public DieselCarDecorator(ICar car) : base(car)
        {
        }

        //Overriding the ManufactureCar method to add Diesel Engine
        public override ICar ManufactureCar()
        {
            //First Call the Concrete Components ManufactureCar Method 
            car.ManufactureCar();
            //Then Add a Diesel Engine by calling the AddEngine Method
            AddEngine(car);
            return car;
        }

        public void AddEngine(ICar car)
        {
            if (car is BMWCar BMWCar)
            {
                BMWCar.Engine = "Petrol Engine";
                Console.WriteLine("DieselCarDecorator added Diesel Engine to the Car : " + car);
            }
        }
    }
}
