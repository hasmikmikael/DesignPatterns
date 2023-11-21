using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Car : IBuilder
    {
        private string brandName;
        private Product product;

        public Car(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }

        public void StartUpOperations()
        {
            //Starting with brandname
            product.Add($"Car Model name : {brandName}");
        }

        public void BuildBody()
        {
            product.Add("This is a body of a Car");
        }

        public void InsertWeels()
        {
            product.Add("4 wheels are added");
        }

        public void AddHeadlights()
        {
            product.Add("2 Headlights are added");
        }

        public void EndOperations()
        {
            //Nothing in this case
        }

        public Product GetVehicle()
        {
            return product;
        }      
    }
}
