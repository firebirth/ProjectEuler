using FluentAssertions;
using Xunit;

namespace ProjectEuler.Utils.Tests
{
    public class NumberHelpersTests
    {
        [Theory]
        [InlineData(54, 24, 6)]
        [InlineData(246, 642, 6)]
        [InlineData(41, 107, 1)]
        [InlineData(2988, 37116, 36)]
        public void Gcd_should_find_greatest_common_divisor(long number1, long number2, long expectedDivisor)
        {
            var actualDivisor = NumberHelpers.Gcd(number1, number2);

            actualDivisor.Should().Be(expectedDivisor);
        }
    }
}
