using FluentAssertions;
using Xunit;

namespace ProjectEuler.Utils.Tests
{
    public class SequenceHelperTests
    {
        [Theory]
        [InlineData(1000, new long[]{ 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987} )]
        [InlineData(500_000, new long[]{ 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811} )]
        [InlineData(100_000_000, new long[]{ 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040, 1346269, 2178309, 3524578, 5702887, 9227465, 14930352, 24157817, 39088169, 63245986 })]
        public void GetFibonacciSequenceUpTo_returns_Fibonacci_sequence(long limit, long[] expected)
        {
            var actual = SequenceHelper.GetFibonacciSequenceUpTo(limit);

            actual.Should().BeEquivalentTo(expected, opts => opts.WithStrictOrdering());
        }

        [Theory]
        [InlineData(13, new[] {13, 40, 20, 10, 5, 16, 8, 4, 2, 1})]
        [InlineData(23, new[] {23, 70, 35, 106, 53, 160, 80, 40, 20, 10, 5, 16, 8, 4, 2, 1})]
        public void GetCollatzSequence_produces_Collatz_sequence(int start, int[] expectedSequence)
        {
            var actualSequence = SequenceHelper.GetCollatzSequence(start);

            actualSequence.Should().BeEquivalentTo(expectedSequence, opts => opts.WithStrictOrdering());
        }
    }
}
