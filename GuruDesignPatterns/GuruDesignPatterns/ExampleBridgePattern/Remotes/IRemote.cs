using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBridgePattern.Remotes
{
    public interface IRemote
    {
        void TogglePower();
        void VolumeDown();
        void VolumeUp();
        void ChannelDown();
        void ChannelUp();
    }
}
