using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBuilderPattern
{
    public class Director
    {
        public void MakeSUV(IBuilder builder)
        {
            builder.SetEngine();
            builder.SetSeats(4);
            builder.SetTripComputer();
            builder.SetGPS();
        }

        public void MakeSportCar(IBuilder builder)
        {
            builder.SetEngine();
            builder.SetSeats(2);
            builder.SetTripComputer();
            builder.SetGPS();
        }
    }
}
