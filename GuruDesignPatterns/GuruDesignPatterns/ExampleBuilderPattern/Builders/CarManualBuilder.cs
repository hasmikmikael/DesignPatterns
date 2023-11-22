using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleBuilderPattern.Cars;
using ExampleBuilderPattern.Components;

namespace ExampleBuilderPattern.Builders
{
    public class CarManualBuilder : IBuilder
    {
        private CarType type;
        private int seats;
        private Engine engine;
        private Transmission transmission;
        private TripComputer tripComputer;
        private GPSNavigator gpsNavigator;

        public void SetSeats(int seats)
        {
            this.seats = seats;
        }

        public void SetCarType(CarType type)
        {
            this.type = type;
        }

        public void SetEngine(Engine engine)
        {
            this.engine = engine;
        }

        public void SetTransmission(Transmission transmission)
        {
            this.transmission = transmission;
        }

        public void SetTripComputer(TripComputer tripComputer)
        {
            this.tripComputer = tripComputer;
        }

        public void SetGPSNavigator(GPSNavigator gpsNavigator)
        {
            this.gpsNavigator = gpsNavigator;
        }

        public Manual GetResult()
        {
            return new Manual(type, seats, engine, transmission, tripComputer, gpsNavigator);
        }
    }
}
