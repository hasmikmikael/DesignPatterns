using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class VCD : ElectronicGoods
    {
        public VCD(IState state) : base(state)
        {

        }

        //Implementation specific:
        //We are delegating the implementation to the Implementor object
        public override void MoveToCurrentState()
        {
            Console.WriteLine("\n VCD is functioning at : ");
            state.MoveState();
        }
    }
}
