using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBuilderPattern.Components
{
    //Just another feature of a car.
    public class Engine
    {
        private double volume;
        private double mileage;
        private bool started;

        public Engine(double volume, double milage)
        {
            this.volume = volume;
            mileage = milage;
        }

        public void On()
        {
            started = true;
        }

        public void Off()
        {
            started = false;
        }

        public bool IsStarted()
        {
            return started;
        }

        public void Go(double mileage)
        {
            if (started)
            {
                this.mileage += mileage;
            }
            else
            {
                Console.WriteLine("Cannot go, you must start engine first!");
            }
        }

        public double GetVolume()
        {
            return volume;
        }

        public double GetMileage()
        {
            return mileage;
        }
    }
}
