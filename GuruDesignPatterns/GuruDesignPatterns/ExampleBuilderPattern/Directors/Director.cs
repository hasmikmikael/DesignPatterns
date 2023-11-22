using ExampleBuilderPattern.Builders;
using ExampleBuilderPattern.Cars;
using ExampleBuilderPattern.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBuilderPattern.Directors
{
    public class Director
    {
        public void ConstructSUV(IBuilder builder)
        {
            builder.SetCarType(CarType.SUV);
            builder.SetSeats(4);
            builder.SetEngine(new Engine(2.5, 0));
            builder.SetTransmission(Transmission.MANUAL);
            builder.SetGPSNavigator(new GPSNavigator());
        }

        public void ConstructSportCar(IBuilder builder)
        {
            builder.SetCarType(CarType.SPORTS_CAR);
            builder.SetSeats(2);
            builder.SetEngine(new Engine(3.0, 0));
            builder.SetTransmission(Transmission.SEMI_AUTOMATIC);
            builder.SetTripComputer(new TripComputer());
            builder.SetGPSNavigator(new GPSNavigator());
        }

        public void ConstructCityCar(IBuilder builder)
        {
            builder.SetCarType(CarType.CITY_CAR);
            builder.SetSeats(2);
            builder.SetEngine(new Engine(1.2, 0));
            builder.SetTransmission(Transmission.AUTOMATIC);
            builder.SetTripComputer(new TripComputer());
            builder.SetGPSNavigator(new GPSNavigator());
        }
    }
}
