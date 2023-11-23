using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Triangle
    {
        public double baseT;
        public double height;

        public Triangle(double baseT, double height)
        {
            this.baseT = baseT;
            this.height = height;
        }
    }
}
