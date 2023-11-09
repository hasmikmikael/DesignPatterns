using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public class Dog : IAnimal
    {
        public void Action()
        {
            Console.WriteLine("Dogs prefer barking...");
        }

        public void Speak()
        {
            Console.WriteLine("Dog says: Bow-Wow.");
        }
    }
}
