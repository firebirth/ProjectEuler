using System;
using System.Collections.Generic;
using System.Linq;

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

        public static bool[] EratosthenesSieve(int limit)
        {
            var sieve = new bool[limit];
            sieve[0] = sieve[1] = true; // 0 and 1 are not primes
            var crossLimit = (int)Math.Floor(Math.Sqrt(limit));
            for (int i = 4; i < limit; i+=2)
            {
                sieve[i] = true;
            }

            for (int i = 3; i <= crossLimit; i+=2)
            {
                if (!sieve[i])
                {
                    for (int j = i*i; j < limit; j+=2*i)
                    {
                        sieve[j] = true;
                    }
                }
            }

            return sieve;
        }

        public static int[] GetPrimesUpTo(int limit) => EratosthenesSieve(limit)
                                                        .Select((b, i) => (IsPrime: !b, Number: i))
                                                        .Where(tuple => tuple.IsPrime)
                                                        .Select(tuple => tuple.Number)
                                                        .ToArray();

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
