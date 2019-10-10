using System.Numerics;

namespace ProjectEuler.Tasks
{
    public static class Problem25
    {
        public static int Calculate()
        {
            var count = 2;
            var limit = BigInteger.Pow(10, 999);
            BigInteger curr = 1, prev1 = 1, prev2 = 1;

            while (curr <= limit)
            {
                count++;
                curr = prev1 + prev2;
                prev2 = prev1;
                prev1 = curr;
            }

            return count;
        }
    }
}
