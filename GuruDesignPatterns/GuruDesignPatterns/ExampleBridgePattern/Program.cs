using ExampleBridgePattern.Devices;
using ExampleBridgePattern.Remotes;

namespace ExampleBridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Bridge Pattern Demo***");

            TestDevice(new Tv());
            TestDevice(new Radio());
        }

        public static void TestDevice(IDevice device)
        {
            Console.WriteLine("Basic Remote");
            BasicRemote basicRemote = new BasicRemote(device);
            basicRemote.TogglePower();
            device.PrintStatus();

            Console.WriteLine("Advanced Remote");
            AdvancedRemote advancedRemote = new AdvancedRemote(device);
            advancedRemote.TogglePower();
            advancedRemote.Mute();
            device.PrintStatus();
        }


        //Output
        //***Bridge Pattern Demo***
        //Basic Remote
        //Remote: power toggle
        //---------------------------------------
        //| I'm TV set.
        //| I'm enabled
        //| Current volume is 30 %
        //| Current channel is 1
        //---------------------------------------

        //Advanced Remote
        //Remote: power toggle
        //Remote: mute
        //---------------------------------------
        //| I'm TV set.
        //| I'm disabled
        //| Current volume is 0 %
        //| Current channel is 1
        //---------------------------------------

        //Basic Remote
        //Remote: power toggle
        //---------------------------------------
        //| I'm radio.
        //| I'm enabled
        //| Current volume is 30 %
        //| Current channel is 1
        //---------------------------------------

        //Advanced Remote
        //Remote: power toggle
        //Remote: mute
        //---------------------------------------
        //| I'm radio.
        //| I'm disabled
        //| Current volume is 0 %
        //| Current channel is 1
        //---------------------------------------
    }
}
