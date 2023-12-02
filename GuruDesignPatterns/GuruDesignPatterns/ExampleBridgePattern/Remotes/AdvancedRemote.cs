using ExampleBridgePattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBridgePattern.Remotes
{
    public class AdvancedRemote : BasicRemote
    {
        public AdvancedRemote(IDevice device) : base(device)
        {
        }

        public void Mute()
        {
            Console.WriteLine("Remote: mute");
            device.SetVolume(0);
        }
    }
}
