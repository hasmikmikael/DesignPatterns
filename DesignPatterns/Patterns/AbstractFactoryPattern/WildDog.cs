using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class WildDog : IDog
    {
        public void Action()
        {
            Console.WriteLine("Wild Dogs prefer to roam freely in jungles.\n");
        }

        public void Speak()
        {
            Console.WriteLine("Wild Dog says: Bow-Wow.");
        }
    }
}
