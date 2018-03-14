using System.Linq;
using ProjectEuler.Utils;

namespace ProjectEuler.Tasks
{
    public static class Problem10
    {
        public static long GetSumOfPrimesBelow(int limit)
        {
            var primes = PrimeHelpers.GetPrimesUpTo(limit);
            return primes.Select(i => (long) i).Sum();
        }
    }
}
