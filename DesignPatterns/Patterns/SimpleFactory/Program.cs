
namespace SimpleFactoryPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Simple Factory Pattern Demo***\n");
            IAnimal prefferedType = null;
            ISimpleFactory simpleFactory = new SimpleFactory();
            #region The code region that will vary based on users preference
            prefferedType = simpleFactory.CreateAnimal();
            #endregion

            #region The codes that do not change frequently
            prefferedType.Speak();
            prefferedType.Action();
            #endregion

            Console.ReadLine();
        }
    }
}