using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using ExampleBuilderPattern.Components;

namespace ExampleBuilderPattern.Cars
{
    //Car is a product class.
    public class Car
    {
        private CarType carType;
        private int seats;
        private Engine engine;
        private Transmission transmission;
        private TripComputer tripComputer;
        private GPSNavigator gPSNavigator;
        private double fuel = 0;

        public Car(CarType carType, int seats, Engine engine, Transmission transmission,
            TripComputer tripComputer, GPSNavigator gPSNavigator)
        {
            this.carType = carType;
            this.seats = seats;
            this.engine = engine;
            this.transmission = transmission;
            this.tripComputer = tripComputer;

            if (tripComputer != null)
            {
                this.tripComputer.SetCar(this);
            }
            this.gPSNavigator = gPSNavigator;
        }

        public CarType GetCarType()
        {
            return carType;
        }

        public double GetFuel()
        {
            return fuel;
        }

        public void SetFuel(double fuel)
        {
            this.fuel = fuel;
        }

        public int GetSeats()
        {
            return seats;
        }

        public Engine GetEngine()
        {
            return engine;
        }

        public Transmission GetTransmission()
        {
            return transmission;
        }

        public TripComputer GetTripComputer()
        {
            return tripComputer;
        }

        public GPSNavigator GetGPSNavigator()
        {
            return gPSNavigator;
        }
    }
}
