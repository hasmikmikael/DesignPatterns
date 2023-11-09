using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class Tiger : IAnimal
    {
        public void Action()
        {
            Console.WriteLine("Tigers prefer hunting...\n");
        }

        public void Speak()
        {
            Console.WriteLine("Tiger says: Halum.");
        }
    }
}
