using BenchmarkDotNet.Attributes;
using JM.Miniatures.M01;
using JM.Miniatures.M01.Other;

namespace JM.Benchmarks
{
    [CoreJob]
    [RPlotExporter, RankColumn]
    public class M01
    {


        [Params(0, 10, 20, 30, 40)]
        public uint n;

        private readonly IFibonacci recursive = new FibonacciNumbersRecursive();
        private readonly IFibonacci quickly = new FibonacciNumbersQuickly();
        private readonly IFibonacci fastDoubling = new FibonacciNumbersFastDoubling();
        private readonly IFibonacci formula = new FibonacciNumbersTheFormula();

        [Benchmark]
        public uint Recursive() => recursive.Compute(n);

        [Benchmark]
        public uint Quickly() => quickly.Compute(n);

        [Benchmark]
        public uint FastDoubling() => fastDoubling.Compute(n);

        [Benchmark]
        public uint Formula() => formula.Compute(n);


    }
}
