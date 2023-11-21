using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class MotorCycle : IBuilder
    {
        private string brandName;
        private Product product;

        public MotorCycle(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }

        public void StartUpOperations()
        {
            //Nothing in this case
        }

        public void BuildBody()
        {
            product.Add("This is a body of a MotorCycle");
        }

        public void InsertWeels()
        {
            product.Add("2 wheels are added");
        }

        public void AddHeadlights()
        {
            product.Add("1 Headlight is added");
        }

        public void EndOperations()
        {
            //Finishing up with brandname
            product.Add($"Motorcycle Model name : {brandName}");
        }

        public Product GetVehicle()
        {
            return product;
        }
    }
}
