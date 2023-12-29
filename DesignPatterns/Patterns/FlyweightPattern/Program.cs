namespace FlyweightPattern
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("***Flyweight Pattern Demo***");

            RobotFactory myFactory = new RobotFactory();
            IRobot shape = myFactory.GetRobotFromFactory("Small");
            shape.Print();

            /*Now we are trying to get the 2 more Small robots.
             Note that: now onwards we need not create additional small 
            robots because Chapter 10 Flyweight Pattern
            130 we have already created one of this category*/

            for (int i = 0; i < 2; i++)
            {
                shape = myFactory.GetRobotFromFactory("Small");
                shape.Print();
            }

            int numOfDistinctRobot = myFactory.TotalObjectsCreated;
            Console.WriteLine("\n Now, total numbers of distinct robot " +
                $"object is = {numOfDistinctRobot} \n");

            /*Here we are trying to get the 5 more Large robots.
             Note that: now onwards we need not create additional small 
            robots because we have already created one of this category */
            for (int i = 0; i < 5; i++)
            {
                shape = myFactory.GetRobotFromFactory("Large");
                shape.Print();
            }

            numOfDistinctRobot = myFactory.TotalObjectsCreated;
            Console.WriteLine($"\n Distinct robot object created till now {numOfDistinctRobot}");
            Console.ReadKey();
        }
    }
}
