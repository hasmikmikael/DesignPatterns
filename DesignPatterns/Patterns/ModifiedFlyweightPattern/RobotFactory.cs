using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ModifiedFlyweightPattern
{
    public class RobotFactory
    {
        Dictionary<string, IRobot> shapes = new Dictionary<string, IRobot>();

        public int TotalObjectsCreated()
        {
            return shapes.Count;
        }

        public IRobot GetRobotFromFactory(string robotType)
        {
            IRobot robotCategory = null;

            if (shapes.ContainsKey(robotType)) 
            {
                robotCategory = shapes[robotType];
            }
            else
            {
                switch (robotType) 
                {
                    case "Small":
                        Console.WriteLine($"We do not have Small Robot at present. So we are creating a Small Robot now.");

                        robotCategory = new Robot("Small");
                        shapes.Add("Small", robotCategory);
                        break;
                    case "Large":
                        Console.WriteLine("We do not have Large Robot at present. So we are creating a Large Robot now.");

                        robotCategory = new Robot("Large");
                        shapes.Add("Large", robotCategory);
                        break;
                    default:
                        throw new Exception("Robot factory can create only small and large robots.");
                }
            }
            return robotCategory;
        }
    }
}
