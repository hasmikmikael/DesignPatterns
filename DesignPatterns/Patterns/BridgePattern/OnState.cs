using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    //ConcreteImplementor-1
    public class OnState : IState
    {
        public void MoveState()
        {
            Console.WriteLine("On State");
        }
    }
}
