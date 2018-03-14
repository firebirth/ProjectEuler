using FluentAssertions;
using Xunit;

namespace ProjectEuler.Utils.Tests
{
    public class NumberHelpersTests
    {
        [Theory]
        [InlineData(54, 24, 6)]
        [InlineData(246, 642, 6)]
        [InlineData(107, 41, 1)]
        [InlineData(2988, 37116, 36)]
        [InlineData(8293457234238529345, 102934572342385293, 1)]
        public void Gcd_should_find_greatest_common_divisor(long number1, long number2, long expectedDivisor)
        {
            var actualDivisor = NumberHelpers.Gcd(number1, number2);

            actualDivisor.Should().Be(expectedDivisor);
        }
    }
}
