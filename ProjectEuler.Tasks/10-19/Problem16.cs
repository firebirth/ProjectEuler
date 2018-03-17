using System.Linq;
using System.Numerics;

namespace ProjectEuler.Tasks
{
    public static class Problem16
    {
        public static long GetSumOfDigistOfTwoPower(int n)
        {
            // think of using (2^6 % 9) = 1
            // thus, since n = 2*k + p, (2^n % 9) = (2^p % 9)
            var pow = BigInteger.Pow(2, n);

            return pow.ToString()
                      .Select(s => s.ToString())
                      .Select(long.Parse)
                      .Sum();
        }
    }
}
