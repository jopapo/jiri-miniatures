using System;

namespace JM.Miniatures.M01
{
    public class FibonacciNumbersTheFormula : IFibonacci
    {

        static double sqrt5 = Math.Sqrt(5);

        public uint Compute(uint n)
        {
            return Convert.ToUInt32((1 / sqrt5) * (Math.Pow((1 + sqrt5) / 2, n) - Math.Pow((1 - sqrt5) / 2, n)));
        }
    }
}
