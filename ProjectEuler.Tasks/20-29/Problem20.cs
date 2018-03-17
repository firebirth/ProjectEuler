using System.Linq;
using System.Numerics;
using ProjectEuler.Utils;

namespace ProjectEuler.Tasks
{
    public static class Problem20
    {
        public static long GetSumOfDigitsOfFactorial(int fact)
        {
            var curr = BigInteger.One;
            for (int i = 2; i <= fact; i++)
            {
                curr *= i;
                if (curr % 10 == 0)
                {
                    curr /= 10;
                }
            }

            return NumberHelpers.GetSumOfDigits(curr.ToString());
        }
    }
}
