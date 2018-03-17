using System.Linq;
using ProjectEuler.Utils;

namespace ProjectEuler.Tasks
{
    public static class Problem21
    {
        private static long GetSumOfDivisors(long number) => NumberHelpers.GetAllFactors(number).Sum();

        private static bool IsAmicable(long number)
        {
            var sumOfDivisors = GetSumOfDivisors(number);
            var sumOfDivisors2 = GetSumOfDivisors(sumOfDivisors);
            return sumOfDivisors2 == number && number != sumOfDivisors;
        }

        public static long SumOfAmicableUnder(int limit)
        {
            return Enumerable.Range(1, limit)
                             .Select(i => (long) i)
                             .Where(IsAmicable)
                             .Sum();
        }
    }
}
