using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleAdapterPattern.Round
{
    public class RoundHole
    {
        public double radius;

        public RoundHole(double radius)
        {
            this.radius = radius;
        }

        public double GetRadius()
        {
            return radius;
        }

        public bool Fits(RoundPeg peg)
        {
            bool results;
            results = (this.GetRadius() >= peg.GetRadius());
            return results;
        }
    }
}
