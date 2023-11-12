using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class PetTiger : ITiger
    {
        public void Action()
        {
            Console.WriteLine("Pet Tigers play in an animal circus.\n");
        }

        public void Speak()
        {
            Console.WriteLine("Pet Tiger says: Halum.");
        }
    }
}
