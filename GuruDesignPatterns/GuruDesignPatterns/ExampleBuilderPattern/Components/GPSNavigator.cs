using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBuilderPattern.Components
{
    //Just another feature of a car.
    public class GPSNavigator
    {
        private string route;

        public GPSNavigator()
        {
            route = "221b, Baker Street, London to Scotland Yard, 8-10 Broadway, London";
        }

        public GPSNavigator(string manualRoute)
        {
            route = manualRoute;
        }

        public string GetRoute()
        {
            return route;
        }
    }
}
