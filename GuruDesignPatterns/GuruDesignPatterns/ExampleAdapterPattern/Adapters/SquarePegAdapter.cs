using ExampleAdapterPattern.Round;
using ExampleAdapterPattern.Square;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleAdapterPattern.Adapters
{
    public class SquarePegAdapter : RoundPeg
    {
        private SquarePeg squarePeg;
        public SquarePegAdapter(SquarePeg squarePeg) 
        {
            this.squarePeg = squarePeg;
        }

        public double GetRadius()
        {
            return Math.Sqrt(2) * squarePeg.GetWidth()/2;
        }
    }
}
