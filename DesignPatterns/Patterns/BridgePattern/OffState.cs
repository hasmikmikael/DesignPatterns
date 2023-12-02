using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    //ConcreteImplementor-2
    public class OffState : IState
    {
        public void MoveState()
        {
            Console.WriteLine("Off State");
        }
    }
}
