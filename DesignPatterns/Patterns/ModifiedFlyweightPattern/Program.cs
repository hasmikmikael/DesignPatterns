namespace ModifiedFlyweightPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            RobotFactory myFactory = new RobotFactory();
            Console.WriteLine("***Flyweight Pattern Example Modified***");

            Robot shape;

            //Here we are trying to get 3 small type robots.
            for (int i = 0; i < 3; i++)
            {
                shape = (Robot)myFactory.GetRobotFromFactory("Small");
                /*Not required to add sleep(). But it is included to
                increase the probability of getting a new random number
                to see the variations in the output.*/
                Thread.Sleep(1000);
                shape.SetColor(GetRandomColor());
                shape.Print();
            }

            //Here we are trying to get 3 large type robots
            for (int i = 0; i < 3; i++)
            {
                shape = (Robot)myFactory.GetRobotFromFactory("Large");
                /*Not required to add sleep().But it is included to
                increase the probability of getting a new random number
                to see the variations in the output.*/
                Thread.Sleep(1000);
                shape.SetColor(GetRandomColor());
                shape.Print();
            }

            int numOfDistinctRobots = myFactory.TotalObjectsCreated();

            Console.WriteLine($"\n Finally no of Distinct Robot objects created: {numOfDistinctRobots}");
            Console.ReadKey();
        }

        static string GetRandomColor()
        {
            Random r = new Random();

            /* You can supply any number of your choice in nextInt argument.
            * we are simply checking the random number generated is an 
            * even number or an odd number. And based on that we are 
            * choosing the color. For simplicity, we'll use only two 
            * color-red and green
            */

            int random = r.Next(100);

            if (random % 2 == 0)
            {
                return "red";
            }
            else
            {
                return "green";
            }
        }
    }
}
