using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiedFlyweightPattern
{
    public class Robot : IRobot
    {
        string robotType;
        public string colorOfRobot;

        public Robot(string robotType)
        {
            this.robotType = robotType;
        }

        public void SetColor(string colorOfRobot)
        {
            this.colorOfRobot = colorOfRobot;
        }
        public void Print()
        {
            Console.WriteLine($"This is a {robotType} type robot with {colorOfRobot} color");
        }
    }
}
