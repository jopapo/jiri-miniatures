using JM.Miniatures.M01;
using JM.Miniatures.M01.Other;
using System.Collections.Generic;
using Xunit;

namespace JM.Tests
{
    public class M01
    {

        private readonly List<IFibonacci> fibs = new List<IFibonacci> {
            new FibonacciNumbersRecursive(), 
            new FibonacciNumbersQuickly(), 
            new FibonacciNumbersFastDoubling(),
            new FibonacciNumbersTheFormula()};

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(21, 10946)]
        public void Should_Compute(uint n, uint r)
        {
            fibs.ForEach(f => Assert.Equal<uint>(r, f.Compute(n)));
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 0)]
        [InlineData(4, 2)]
        [InlineData(20, 10946)]
        [InlineData(21, 10945)]
        public void Should_Fail(uint n, uint r)
        {
            fibs.ForEach(f => Assert.True(r != f.Compute(n)));
        }



    }
}
