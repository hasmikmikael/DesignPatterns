using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleBuilderPattern.Cars;
using ExampleBuilderPattern.Components;

namespace ExampleBuilderPattern.Builders
{
    public interface IBuilder
    {
        void SetCarType(CarType type);
        void SetSeats(int seats);
        void SetEngine(Engine engine);
        void SetTransmission(Transmission transmission);
        void SetTripComputer(TripComputer tripComputer);
        void SetGPSNavigator(GPSNavigator gpsNavigator);
    }
}
