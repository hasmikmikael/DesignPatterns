using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class WildTiger : ITiger
    {
        public void Action()
        {
            Console.WriteLine("Wild Tigers prefer hunting in jungles.\n");
        }

        public void Speak()
        {
            Console.WriteLine("Wild Tiger says: Halum.");
        }
    }
}
