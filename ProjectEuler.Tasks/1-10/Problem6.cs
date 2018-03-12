using System.Linq;

namespace ProjectEuler.Tasks
{
    public static class Problem6
    {
        public static long SumSquareDifference(long n)
        {
            var pow2 = n * n;
            var pow3 = pow2 * n;
            var pow4 = pow2 * pow2;

            return (3 * pow4 + 2 * pow3 - 3 * pow2 - 2 * n) / 12;
        }
    }
}
