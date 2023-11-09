namespace FactoryMethodPattern
{
    public class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Factory Pattern Demo***\n");

            //Create a Tiger Factory
            IAnimalFactory tigerFactory = new TigerFactory();

            //Creating a tiger using the Factory Method
            IAnimal aTiger = tigerFactory.CreateAnimal();
            aTiger.Speak();
            aTiger.Action();

            //Create a Dog Factory
            IAnimalFactory dogFactory = new DogFactory();

            //Creating a dog using the Factory Method
            IAnimal aDog = dogFactory.CreateAnimal();
            aDog.Speak();
            aDog.Action();

            Console.ReadKey();
        }
    }
}
