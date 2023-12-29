using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class SmallRobot : IRobot
    {
        public void Print()
        {
            Console.WriteLine("This is a Small Robot");
        }
    }
}
