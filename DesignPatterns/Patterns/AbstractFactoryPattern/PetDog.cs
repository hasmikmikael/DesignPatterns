using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class PetDog : IDog
    {
        public void Action()
        {
            Console.WriteLine("Pet Dogs prefer to stay at home.\n");
        }

        public void Speak()
        {
            Console.WriteLine("Pet Dog says: Bow-Wow.");
        }
    }
}
