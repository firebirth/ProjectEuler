using System;
using System.Collections.Generic;

namespace ProjectEuler.Utils
{
    public static class PrimeHelpers
    {
        public static long Gcd(long x, long y)
        {
            if (x == 0)
            {
                return y;
            }

            if (y == 0)
            {
                return x;
            }

            x = x % y;
            return Gcd(y, x);
        }

        public static IEnumerable<long> GetPrimeFactors(long number)
        {
            while (number > 1)
            {
                var divisor = GetSmallestDivisor(number);
                yield return divisor;
                number /= divisor;
            }
        }

        private static long GetSmallestDivisor(long number)
        {
            var upperLimit = Math.Sqrt(number);
            for (long i = 2; i <= upperLimit; i++)
            {
                if (number % i == 0)
                {
                    return i;
                }
            }

            return number;
        }
    }
}
