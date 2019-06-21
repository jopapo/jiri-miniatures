namespace JM.Miniatures.M01
{
    public class FibonacciNumbersQuickly : IFibonacci
    {

        private uint[,] initM = { { 1, 1 }, { 1, 0 } };

        public uint Compute(uint n)
        {
            if (n == 0) return 0;
            var m = Power(initM, n - 1);
            return m[0, 0];
        }

        private uint[,] Power(uint[,] m, uint n)
        {
            if (n <= 1) return m;
            m = Power(m, n / 2);
            m = Multiply(m, m);
            if (n % 2 != 0)
            {
                m = Multiply(m, initM);
            }
            return m;
        }

        private uint[,] Multiply(uint[,] nm, uint[,] m)
        {
            uint x = nm[0, 0] * m[0, 0] + nm[0, 1] * m[1, 0];
            uint y = nm[0, 0] * m[0, 1] + nm[0, 1] * m[1, 1];
            uint z = nm[1, 0] * m[0, 0] + nm[1, 1] * m[1, 0];
            uint w = nm[1, 0] * m[0, 1] + nm[1, 1] * m[1, 1];

            return new uint[,] { { x, y }, { z, w } };
        }
    }
}
