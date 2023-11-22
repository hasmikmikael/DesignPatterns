using ExampleBuilderPattern.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBuilderPattern.Components
{
    //Just another feature of a car.
    public class TripComputer
    {
        private Car car;

        public void SetCar(Car car)
        {
            this.car = car;
        }

        public void ShowFuelLevel()
        {
            Console.WriteLine("Fuel level: " + car.GetFuel());
        }

        public void ShowStatus()
        {
            if (car.GetEngine().IsStarted())
            {
                Console.WriteLine("Car is started");
            }
            else
            {
                Console.WriteLine("Car isn't started");
            }
        }
    }
}
