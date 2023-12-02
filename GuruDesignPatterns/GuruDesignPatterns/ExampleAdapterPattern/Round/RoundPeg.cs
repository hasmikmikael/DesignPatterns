using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleAdapterPattern.Round
{
    public class RoundPeg
    {
        public double radius;

        public RoundPeg() { }

        public RoundPeg(double radius)
        {
            this.radius = radius;
        }

        public double GetRadius() 
        {
            return radius;
        }
    }
}
