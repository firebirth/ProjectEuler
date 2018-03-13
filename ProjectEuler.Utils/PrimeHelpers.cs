using System;
using System.Collections.Generic;

namespace ProjectEuler.Utils
{
    public static class PrimeHelpers
    {
        public static bool IsPrime(long n)
        {
            if (n == 1)
            {
                return false;
            }

            if (n < 4)
            {
                return true;
            }

            if (n % 2 == 0)
            {
                return false;
            }

            if (n < 9)
            {
                return true;
            }

            if (n % 3 == 0)
            {
                return false;
            }

            var upperLimit = (long)Math.Round(Math.Sqrt(n), MidpointRounding.AwayFromZero);
            var divisor = 5;
            while (divisor <= upperLimit)
            {
                if (n % divisor == 0)
                {
                    return false;
                }

                if (n % (divisor + 2) == 0)
                {
                    return false;
                }

                divisor += 6;
            }

            return true;
        }

        public static IEnumerable<long> GetNonTrivialPrimeFactors(long number)
        {
            var originalNumber = number;
            while (number > 1)
            {
                var divisor = GetSmallestDivisor(number);
                if (divisor != originalNumber)
                {
                    yield return divisor;
                }

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
