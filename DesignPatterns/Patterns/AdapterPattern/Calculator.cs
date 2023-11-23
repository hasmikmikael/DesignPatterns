using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Calculator
    {
        public double GetArea(Rectangle rect)
        {
            return rect.width * rect.length;
        }
    }
}
