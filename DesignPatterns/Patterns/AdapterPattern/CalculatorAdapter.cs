using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class CalculatorAdapter
    {
        public double GetArea(Triangle triangle)
        {
            Calculator cal = new Calculator();
            Rectangle rect = new Rectangle();

            //Area of Triangle = 0.5 * base * height
            rect.length = triangle.baseT;
            rect.width = 0.5 * triangle.height;

            return cal.GetArea(rect);
        }
    }
}
