using System;
using System.Collections.Generic;

namespace exam101
{
    class FibonacciSeries
    {
        public static List<int> fibo(FiboSeed seeds, int iterations)
        {
            Console.WriteLine("Fibo initial seeds: (lower) = " + seeds.LowerSeed + " (upper) = " + seeds.UpperSeed);
            var fiboSeries = new List<int>();

            fiboSeries.Add(seeds.LowerSeed);

            int nextSeed = 0;
            int prevSeed = seeds.LowerSeed;
            int holdingSeed = seeds.UpperSeed;

            for (int i = 0; i < iterations; i++)
            {
                nextSeed = prevSeed + holdingSeed;

                fiboSeries.Add(nextSeed);

                // reassignments
                holdingSeed = prevSeed;
                prevSeed = nextSeed;
                
            }

            return fiboSeries;
        }
    }

    class FiboSeed
    {
        public readonly int UpperSeed = 1;

        public readonly int LowerSeed = 1;

        public FiboSeed() 
        {

        }

        public FiboSeed(int lowerSeed, int upperSeed)
        {
            if (lowerSeed <= 0 || upperSeed <= 0)
            {
                throw new BoundsExceptions("Seeds must be greater than zero");
            }

            if (lowerSeed > upperSeed)
            {
                throw new BoundsExceptions("Lower seed must be less than upper seed");
            }

            this.LowerSeed = lowerSeed;
            this.UpperSeed = upperSeed;

        }


    }

    class BoundsExceptions : Exception
    {
        public BoundsExceptions()
        {
            Console.WriteLine("Invalid seeds, they must not be negative, upper seed must be greater than lower seed");
        }

        public BoundsExceptions(string message)
            : base(message)
        {
            Console.WriteLine(message);
        }

        public BoundsExceptions(string message, Exception inner)

           : base(message, inner)
        {
            Console.WriteLine(message);
        }
    }
}