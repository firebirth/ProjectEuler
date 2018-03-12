using FluentAssertions;
using Xunit;

namespace ProjectEuler.Utils.Tests
{
    public class FibonacciHelperTests
    {
        [Theory]
        [InlineData(1000, new long[]{ 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987} )]
        [InlineData(500_000, new long[]{ 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811} )]
        [InlineData(100_000_000, new long[]{ 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040, 1346269, 2178309, 3524578, 5702887, 9227465, 14930352, 24157817, 39088169, 63245986 })]
        public void GetFibonacciSequenceUpTo_returns_Fibonacci_sequence(long limit, long[] expected)
        {
            var actual = FibonacciHelper.GetFibonacciSequenceUpTo(limit);

            actual.Should().BeEquivalentTo(expected, opts => opts.WithStrictOrdering());
        }
    }
}
