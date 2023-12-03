using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiedAdapterPattern
{
    public class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Length = height;
        }

        public void AboutRectangle()
        {
            Console.WriteLine("Actually, I am a Rectangle");
        }

        public double CalculateAreaOfRectangle()
        {
            return Width * Length;
        }
    }
}
