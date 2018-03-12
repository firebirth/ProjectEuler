using FluentAssertions;
using Xunit;

namespace ProjectEuler.Tasks.Tests
{
    public class Problem8Tests
    {
        [Theory]
        [InlineData(2, 81)]
        [InlineData(3, 648)]
        [InlineData(4, 5832)]
        [InlineData(13, 23514624000)]
        public void Test1(int adjacentCount, long expectedProduct)
        {
            var actualProduct = Problem8.GetLargestAdjacentProduct(adjacentCount);

            actualProduct.Should().Be(expectedProduct);
        }
    }
}
