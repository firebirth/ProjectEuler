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
        [InlineData(271, new long[] {271})]
        [InlineData(600851475143, new long[] {71, 839, 1471, 6857})]
        public void GetPrimeFactors_should_generate_divisors(long number, long[] expectedDivisors)
        {
            var actualDivisors = PrimeHelpers.GetPrimeFactors(number);

            actualDivisors.Should().BeEquivalentTo(expectedDivisors);
        }

        [Theory]
        [InlineData(54,24,6)]
        [InlineData(246,642,6)]
        [InlineData(41, 107, 1)]
        [InlineData(2988, 37116, 36)]
        public void Gcd_should_find_greatest_common_divisor(long number1, long number2, long expectedDivisor)
        {
            var actualDivisor = PrimeHelpers.Gcd(number1, number2);

            actualDivisor.Should().Be(expectedDivisor);
        }
    }
}
