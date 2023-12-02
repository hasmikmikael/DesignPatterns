using ExampleAdapterPattern.Adapters;
using ExampleAdapterPattern.Round;
using ExampleAdapterPattern.Square;

namespace ExampleAdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Adapter Pattern Demo***");

            RoundHole hole = new RoundHole(5);
            RoundPeg rpeg = new RoundPeg(5);

            if (hole.Fits(rpeg))
            {
                Console.WriteLine("Round peg r5 fits round hole r5");
            }

            SquarePeg smallSqPeg = new SquarePeg(2);
            SquarePeg largeSqPeg = new SquarePeg(20);
            //hole.Fits(smallSqPeg); //Won;t compile.

            //Adapter solves the problem.
            SquarePegAdapter smallSqPegAdapter = new SquarePegAdapter(smallSqPeg);
            SquarePegAdapter largeSqPegAdapter = new SquarePegAdapter(largeSqPeg);

            if (hole.Fits(smallSqPegAdapter))
            {
                Console.WriteLine("Square peg w2 fits round hole r5.");
            }
            if (!hole.Fits(largeSqPegAdapter))
            {
                Console.WriteLine("Square peg w20 does not fit into round hole r5.");
            }
        }
    }
}
