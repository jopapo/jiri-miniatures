namespace JM.Miniatures.M01.Other
{
    public class FibonacciNumbersFastDoubling : IFibonacci
    {
        public uint Compute(uint n)
        {
            uint a = 0;
            uint b = 1;
            for (int i = 31; i >= 0; i--)
            {
                uint d = a * (b * 2 - a);
                uint e = a * a + b * b;
                a = d;
                b = e;
                if ((((uint)n >> i) & 1) != 0)
                {
                    uint c = a + b;
                    a = b;
                    b = c;
                }
            }
            return a;
        }
    }
}
