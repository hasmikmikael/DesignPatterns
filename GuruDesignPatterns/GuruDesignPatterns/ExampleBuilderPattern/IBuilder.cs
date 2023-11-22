using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBuilderPattern
{
    public interface IBuilder
    {
        void SetSeats(int number);
        void SetEngine();
        void SetTripComputer();
        void SetGPS();
    }
}
