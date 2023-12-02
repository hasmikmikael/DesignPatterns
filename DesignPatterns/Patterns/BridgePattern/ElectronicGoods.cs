using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    //Abstraction
    public abstract class ElectronicGoods
    {
        //Composition - implementor
        protected IState state;

        //Alternative approach to constructor:
        //we can also pass an implementor like this:
        //public IState State
        //{
        //    get
        //    {
        //        return state;
        //    }
        //    set
        //    {
        //        state = value;
        //    }
        //}
        public ElectronicGoods(IState state)
        {
            this.state = state;
        }

        abstract public void MoveToCurrentState();
    }
}
