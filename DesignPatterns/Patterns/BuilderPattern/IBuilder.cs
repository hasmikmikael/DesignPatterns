using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IBuilder
    {
        void StartUpOperations();
        void BuildBody();
        void AddHeadlights();               
        void InsertWeels();
        void EndOperations();
        Product GetVehicle();
    }
}
