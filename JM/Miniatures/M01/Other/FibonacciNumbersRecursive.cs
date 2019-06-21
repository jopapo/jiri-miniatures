namespace JM.Miniatures.M01.Other
{
    public class FibonacciNumbersRecursive : IFibonacci
    {
        public uint Compute(uint n)
        {
            if (n <= 1) return n;
            if (n <= 2) return 1;
            return Compute(n - 1) + Compute(n - 2);
        }
    }
}
