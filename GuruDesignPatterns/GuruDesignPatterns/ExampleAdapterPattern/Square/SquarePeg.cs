using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleAdapterPattern.Square
{
    public class SquarePeg
    {
        public double width;

        public SquarePeg(double width)
        {
            this.width = width;
        }

        public double GetWidth()
        {
            return width;
        }

        public double GetSquare()
        {
            return Math.Pow(width, 2);
        }
    }
}
