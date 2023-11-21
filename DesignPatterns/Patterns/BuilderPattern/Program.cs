namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Builder Pattern Demo***\n");
            Director director = new Director();

            IBuilder builderCar = new Car("Ford");
            IBuilder builderMotorcycle = new MotorCycle("Honda");

            //Making Car
            director.Construct(builderCar);
            Product car = builderCar.GetVehicle();
            car.Show();

            //Making MotorCycle
            director.Construct(builderMotorcycle);
            Product motorCycle = builderMotorcycle.GetVehicle();
            motorCycle.Show();
        }
    }    
}
