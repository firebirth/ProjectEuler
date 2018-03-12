using FluentAssertions;
using Xunit;

namespace ProjectEuler.Utils.Tests
{
    public class PalindromeHelperTests
    {
        [Theory]
        [InlineData(7007, true)]
        [InlineData(7707, false)]
        [InlineData(707, true)]
        [InlineData(777, true)]
        [InlineData(7077, false)]
        [InlineData(1234, false)]
        public void Int_IsPalindrome_should_return_whether_number_is_polindrome(int number, bool expectedIsPalindrome)
        {
            var actualIsPalindrome = PalindromeHelper.IsPalindrome(number);

            actualIsPalindrome.Should().Be(expectedIsPalindrome);
        }
    }
}
