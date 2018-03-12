using System.Linq;
using ProjectEuler.Utils;

namespace ProjectEuler.Tasks
{
    public static class Problem3
    {
        public static long GetLargestPrimeFactor(long number)
        {
            var primeFactors = PrimeHelpers.GetPrimeFactors(number);

            return primeFactors.Max();
        }
    }
}
