using System;
using System.Collections.Generic;

namespace ProjectEuler.Utils
{
    public static class FibonacciHelper
    {
        private const double K = 0.8047189562170501;
        private const double LogPhi = 0.48121182505960344;

        public static long[] GetFibonacciSequenceUpTo(long limit)
        {
            var listLength = (int)Math.Round((Math.Log(limit) + K) / LogPhi, MidpointRounding.AwayFromZero);

            long i1 = 2, i2 = 1;
            var sequence = new List<long>(listLength) {i2, i1};
            while (true)
            {
                var acc = i1 + i2;
                if (acc >= limit)
                {
                    break;
                }

                i2 = i1;
                i1 = acc;
                
                sequence.Add(acc);
            }

            return sequence.ToArray();
        }

    }
}
