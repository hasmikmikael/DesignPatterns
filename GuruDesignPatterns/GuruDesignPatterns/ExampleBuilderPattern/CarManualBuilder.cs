using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBuilderPattern
{
    public class CarManualBuilder : IBuilder
    {
        Manual manual;
        public CarManualBuilder() 
        {
            manual = new Manual();
        }

        public void SetEngine()
        {
            manual.Add("Add engine instructions.");
        }

        public void SetGPS()
        {
            manual.Add("Add GPS instructions.");
        }

        public void SetSeats(int number)
        {
            manual.Add($"Document car seat features for {number} seats.");
        }

        public void SetTripComputer()
        {
            manual.Add("Add trip computer instructions.");
        }

        public Manual GetResult()
        {
            return manual;
        }
    }
}
