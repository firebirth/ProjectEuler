using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Utils
{
    public static class SequenceHelper
    {
        public static long[] GetFibonacciSequenceUpTo(long limit)
        {
            const double k = 0.8047189562170501;
            const double logPhi = 0.48121182505960344;
            var listLengthLimit = (int) Math.Round((Math.Log(limit) + k) / logPhi, MidpointRounding.AwayFromZero);

            return GetFibonacciSequence()
                   .Take(listLengthLimit)
                   .Where(i => i < limit)
                   .ToArray();
        }

        public static IEnumerable<long> GetFibonacciSequence()
        {
            yield return 1;
            yield return 2;
            long i1 = 2, i2 = 1;
            while (true)
            {
                var acc = i1 + i2;
                i2 = i1;
                i1 = acc;
                yield return acc;
            }
        }

        public static IEnumerable<long> GetCollatzSequence(int number)
        {
            var current = (long) number;

            yield return current;

            while (current > 1)
            {
                if (current % 2 == 0)
                {
                    yield return current /= 2;
                }
                else
                {
                    yield return current = current * 3 + 1;
                }
            }
        }
    }
}
