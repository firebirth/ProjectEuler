using System.Linq;
using ProjectEuler.Utils;

namespace ProjectEuler.Tasks
{
    public static class Problem12
    {
        public static long GetTriangleNumberWithDivisors(int divisorsCount)
        {
            int triangleNumber = 0,
                currentTriangleNumberIndex = 0,
                currentDivisorsCount;
            divisorsCount -= 2; // let's ignore trivial factors
            do
            {
                currentTriangleNumberIndex++;
                triangleNumber += currentTriangleNumberIndex;
                currentDivisorsCount = PrimeHelpers.GetNonTrivialPrimeFactors(triangleNumber)
                    .GroupBy(i => i)
                    .Select(g => g.Count())
                    .Aggregate(1, (prev, count) => prev * (count + 1));
            } while (currentDivisorsCount < divisorsCount);

            return triangleNumber;
        }
    }
}
