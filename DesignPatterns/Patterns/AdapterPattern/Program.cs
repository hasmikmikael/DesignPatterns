namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Adapter Pattern Demo***\n");

            Calculator cal = new Calculator();
            Rectangle rect = new Rectangle() { length = 10, width = 20 };
            Console.WriteLine($"Area of Rectangle is {cal.GetArea(rect)} Square unit");

            CalculatorAdapter calAdapter = new CalculatorAdapter();
            Triangle triangle = new Triangle(20, 10);
            Console.WriteLine($"Area of Triangle is {calAdapter.GetArea(triangle)} Square unit");
            Console.ReadKey();
        }
    }
}
