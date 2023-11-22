using System.Collections.Generic;
using System.Reflection.Metadata;

namespace ExampleBuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Builder Pattern Demo***\n");
            Director director = new Director();

            CarBuilder builderCar = new CarBuilder();
            Console.WriteLine("Making SUV.");
            director.MakeSUV(builderCar);

            Console.WriteLine("Making Sport Car.");
            director.MakeSportCar(builderCar);
            Car car = builderCar.GetResult();

            Console.WriteLine();
            CarManualBuilder builderManual = new CarManualBuilder();

            Console.WriteLine("Making manual for the SUV.");
            director.MakeSUV(builderManual);

            Console.WriteLine("Making manual for the Sport Car.");
            director.MakeSportCar(builderManual);
            Manual manual = builderManual.GetResult();

            //Output

            //***Builder Pattern Demo***

            //Making SUV.
            //Install a given engine.
            //Set the 4 seats in the car.
            //Install a trip computer.
            //Install a global positioning system.
            //Making Sport Car.
            //Install a given engine.
            //Set the 2 seats in the car.
            //Install a trip computer.
            //Install a global positioning system.

            //Making manual for the SUV.
            //Add engine instructions.
            //Document car seat features for 4 seats.
            //Add trip computer instructions.
            //Add GPS instructions.
            //Making manual for the Sport Car.
            //Add engine instructions.
            //Document car seat features for 2 seats.
            //Add trip computer instructions.
            //Add GPS instructions.
        }
    }
}
