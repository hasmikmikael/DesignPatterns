namespace ModifiedAdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Adapter Pattern Modified Demo***");

            Rectangle rect = new Rectangle(20, 10);
            Console.WriteLine($"Area of Rectangle is : {rect.CalculateAreaOfRectangle()} square unit");

            Triangle triangle = new Triangle(20, 10);
            Console.WriteLine($"Area of Triangle is : {triangle.CalculateAreaOfTriangle()} square unit");

            IRectangle triAdapter = new TriangleAdapter(triangle);
            //Passing a Triangle instead of a Rectangle
            triAdapter.AboutRectangle();

            Console.WriteLine($"Area of Triangle using the triangle adapter is : {triAdapter.CalculateAreaOfRectangle()} square unit");

            Console.ReadKey();

        }
    }
}
