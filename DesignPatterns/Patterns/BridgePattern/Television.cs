using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    //Refined Abstraction
    public class Television : ElectronicGoods
    {
        public Television(IState state) : base(state)
        {

        }

        //Implementation specific:
        //We are delegating the implementation to the Implementor object
        public override void MoveToCurrentState()
        {
            Console.WriteLine("\n Television is functioning at : ");
            state.MoveState();
        }
    }
}
