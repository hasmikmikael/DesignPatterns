namespace PrototypePattern
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Prototype Pattern Demo***\n");

            //Base or Original Copy
            BasicCar nano = new Nano("Green Nano") { Price = 100000 };
            BasicCar ford = new Ford("Ford Yellow") { Price = 500000 };

            BasicCar copy;

            //Nano
            copy = nano.Clone();
            copy.Price = nano.Price + BasicCar.SetPrice();
            Console.WriteLine("Car is: {0}, and it's price is {1} dollars.", 
                copy.ModelName, copy.Price);
            Console.WriteLine("Original car is: {0}, and it's price is {1} dollars.",
                nano.ModelName, nano.Price);

            //Ford
            copy = ford.Clone();
            copy.Price = ford.Price + BasicCar.SetPrice();
            Console.WriteLine("Car is: {0}, and it's price is {1} dollars.",
                copy.ModelName, copy.Price);
            Console.WriteLine("Original car is: {0}, and it's price is {1} dollars.",
                ford.ModelName, ford.Price);
        }
    }
}