using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public abstract class BasicCar
    {
        public string? ModelName { get; set; }
        public int Price { get; set; }
        public static int SetPrice()
        {
            int price = 0;
            Random random = new Random();
            int p = random.Next(10000, 50000);
            price = p;

            return price;

        }
        public abstract BasicCar Clone();
    }
}
