using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiedAdapterPattern
{
    public class Triangle : ITriangle
    {
        public double BaseT { get; set; }
        public double Height { get; set; }

        public Triangle(double baseT, double height)
        {
            BaseT = baseT;
            Height = height;
        }

        public void AboutTriangle()
        {
            Console.WriteLine("Actually, I am a Triangle");
        }

        public double CalculateAreaOfTriangle()
        {
            return 0.5 * BaseT * Height;
        }
    }
}
