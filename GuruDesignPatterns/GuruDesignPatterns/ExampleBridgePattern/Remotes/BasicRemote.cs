using ExampleBridgePattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBridgePattern.Remotes
{
    public class BasicRemote : IRemote
    {
        protected IDevice device;

        public BasicRemote(IDevice device)
        {
            this.device = device;
        }

        public void TogglePower()
        {
            Console.WriteLine("Remote: power toggle");

            if (this.device.IsEnabled())
            {
                device.Disable();
            }
            else
            {
                device.Enable();
            }
        }

        public void VolumeDown()
        {
            Console.WriteLine("Remote: volume down");

            device.SetVolume(device.GetVolume() - 10);
        }
        public void VolumeUp()
        {
            Console.WriteLine("Remote: volume up");

            device.SetVolume(device.GetVolume() + 10);
        }

        public void ChannelDown()
        {
            Console.WriteLine("Remote: channel down");

            device.SetChannel(device.GetChannel() - 1);
        }

        public void ChannelUp()
        {
            Console.WriteLine("Remote: channel up");

            device.SetChannel(device.GetChannel() + 1);
        }
    }
}
