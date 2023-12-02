using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBridgePattern.Devices
{
    public class Radio : IDevice
    {
        bool on = false;
        int volume = 30;
        int channel = 1;

        public bool IsEnabled()
        {
            return on;
        }

        public void Disable()
        {
            on = false;
        }

        public void Enable()
        {
            on = true;
        }

        public int GetChannel()
        {
            return channel;
        }

        public int GetVolume()
        {
            return volume;
        }

        public void SetChannel(int channel)
        {
            this.channel = channel;
        }

        public void SetVolume(int volume)
        {
            if (volume > 100)
            {
                this.volume = 100;
            } else if (volume < 0) 
            {
                this.volume = 0;
            } else
            {
                this.volume = volume;
            }
        }

        public void PrintStatus()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("| I'm radio.");
            Console.WriteLine("| I'm " + (on ? "enabled" : "disabled"));
            Console.WriteLine($"| Current volume is {volume} %");
            Console.WriteLine($"| Current channel is {channel}");
            Console.WriteLine("---------------------------------------\n");
        }
    }
}
