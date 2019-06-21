using BenchmarkDotNet.Running;

namespace JM.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<M01>();
        }
    }
}
