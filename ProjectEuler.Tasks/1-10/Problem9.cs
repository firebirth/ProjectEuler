using System;
using ProjectEuler.Utils;

namespace ProjectEuler.Tasks
{
    public static class Problem9
    {
        public static (long a, long b, long c) GetPythagoreanTripletWhichSumsTo(long sum)
        {
            var halfSum = sum / 2;
            var limit = (int) Math.Round(Math.Sqrt(halfSum), MidpointRounding.AwayFromZero) - 1;
            for (int divisor = 2; divisor < limit; divisor++)
            {
                if (halfSum % divisor != 0)
                {
                    continue;
                }

                var sm = halfSum / divisor;
                while (sm % 2 == 0)
                {
                    sm /= 2;
                }

                int k = divisor % 2 == 1 ? divisor + 2 : divisor + 1;

                while (k < 2 * divisor && k <= sm)
                {
                    if (sm % k == 0 && NumberHelpers.Gcd(k, divisor) == 1)
                    {
                        var gcd = halfSum / (k * divisor);
                        var n = k - divisor;

                        var a = gcd * (divisor * divisor - n * n);
                        var b = 2 * gcd * divisor * n;
                        var c = gcd * (divisor * divisor + n * n);

                        return (a, b, c);
                    }

                    k += 2;
                }
            }

            return default;
        }
    }
}
