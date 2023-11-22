using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBuilderPattern
{
    public class CarBuilder : IBuilder
    {
        Car car;
        public CarBuilder() 
        {
            car = new Car();
        }
        public void SetEngine()
        {
            car.Add("Install a given engine.");
        }

        public void SetGPS()
        {
            car.Add("Install a global positioning system.");
        }

        public void SetSeats(int number)
        {
            car.Add($"Set the {number} seats in the car.");
        }

        public void SetTripComputer()
        {
            car.Add("Install a trip computer.");
        }

        public Car GetResult()
        {
            return car;
        }
    }
}
