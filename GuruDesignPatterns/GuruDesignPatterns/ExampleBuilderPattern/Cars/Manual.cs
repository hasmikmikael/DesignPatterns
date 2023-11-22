using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleBuilderPattern.Components;

namespace ExampleBuilderPattern.Cars
{
    //Car manual is another product. Note that it does not have the same ancestor
    //as a Car. They are not related.
    public class Manual
    {
        private CarType carType;
        private int seats;
        private Engine engine;
        private Transmission transmission;
        private TripComputer tripComputer;
        private GPSNavigator gPSNavigator;

        public Manual(CarType carType, int seats, Engine engine, Transmission transmission,
            TripComputer tripComputer, GPSNavigator gPSNavigator)
        {
            this.carType = carType;
            this.seats = seats;
            this.engine = engine;
            this.transmission = transmission;
            this.tripComputer = tripComputer;
            this.gPSNavigator = gPSNavigator;
        }

        public string Print()
        {
            string info = string.Empty;
            info += $"Type of car: {carType}\n";
            info += $"Count of seats: {seats}\n";
            info += $"Engine: volume - {engine.GetVolume()} ; mileage - {engine.GetMileage()}\n";
            info += $"Transmission: {transmission}\n";

            if (tripComputer != null)
            {
                info += "Trip Computer: Functional\n";
            }
            else
            {
                info += "Trip Computer: N/A\n";
            }

            if (gPSNavigator != null)
            {
                info += "GPS Navigator: Functional\n";
            }
            else
            {
                info += "GPS Navigator: N/A\n";
            }
            return info;
        }
    }
}
