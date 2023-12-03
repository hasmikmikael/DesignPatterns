using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiedAdapterPattern
{
    public class TriangleAdapter : IRectangle
    {
        Triangle triangle;

        public TriangleAdapter(Triangle triangle)
        {
            this.triangle = triangle;
        }
        public void AboutRectangle()
        {
            triangle.AboutTriangle();
        }

        public double CalculateAreaOfRectangle()
        {
            return triangle.CalculateAreaOfTriangle();
        }
    }
}
