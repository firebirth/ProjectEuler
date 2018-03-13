using FluentAssertions;
using Xunit;

namespace ProjectEuler.Utils.Tests
{
    public class PrimeHelpersTests
    {
        [Theory]
        [InlineData(8051, new long[] {97, 83})]
        [InlineData(10403, new long[] {101, 103})]
        [InlineData(12, new long[] {2, 2, 3})]
        [InlineData(90, new long[] {2, 3, 3, 5})]
        [InlineData(6125, new long[] {7, 7, 5, 5, 5})]
        [InlineData(271, new long[0])]
        [InlineData(600851475143, new long[] {71, 839, 1471, 6857})]
        public void GetNonTrivialPrimeFactors_should_generate_non_trivial_divisors(long number, long[] expectedDivisors)
        {
            var actualDivisors = PrimeHelpers.GetNonTrivialPrimeFactors(number);

            actualDivisors.Should().BeEquivalentTo(expectedDivisors);
        }

        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(1747, true)]
        [InlineData(2729, true)]
        [InlineData(3413, true)]
        [InlineData(1579, true)]
        [InlineData(2551, true)]
        [InlineData(6, false)]
        [InlineData(9, false)]
        [InlineData(6292, false)]
        [InlineData(7990, false)]
        public void IsPrime_should_return_true_only_for_primes(long number, bool expectedIsPrime)
        {
            var actualIsPrime = PrimeHelpers.IsPrime(number);

            actualIsPrime.Should().Be(expectedIsPrime);
        }
    }
}
