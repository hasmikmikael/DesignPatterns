namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Bridge Pattern Demo***");

            Console.WriteLine("\nDealing with a Television:");

            IState state = new OnState();
            ElectronicGoods electronics = new Television(state);
            //ElectronicGoods electronics = new Television();
            //electronics.State = state;
            electronics.MoveToCurrentState();

            //Verifying Off state of the Television now
            state = new OffState();
            electronics = new Television(state);
            //electronics.State = state;
            electronics.MoveToCurrentState();

            Console.WriteLine("\n \nDealing with a VCD:");

            state = new OnState();
            electronics = new VCD(state);
            //electronics = new VCD();
            //electronics.State = state;
            electronics.MoveToCurrentState();

            state = new OffState();
            electronics = new VCD(state);
            //electronics = new VCD();
            //electronics.State = state;
            electronics.MoveToCurrentState();

            Console.ReadLine();
        }

        //Output
        //***Bridge Pattern Demo***

        //Dealing with a Television:

        // Television is functioning at :
        //On State

        // Television is functioning at :
        //Off State


        //Dealing with a VCD:

        // VCD is functioning at :
        //On State

        // VCD is functioning at :
        //Off State
    }
}