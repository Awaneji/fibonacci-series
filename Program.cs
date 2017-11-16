using System;

namespace exam101
{
    class Program
    {
        static void Main(string[] args)
        {
            FiboSeed seeds = new FiboSeed(3,3);
            FibonacciSeries.fibo(seeds, 7).ForEach(s => Console.WriteLine(s));
            Console.Read();
        }
    }
}
