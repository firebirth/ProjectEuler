using ProjectEuler.Utils;

namespace ProjectEuler.Tasks
{
    public static class Problem10
    {
        public static long GetSumOfPrimesBelow(int limit)
        {
            var sieve = PrimeHelpers.EratosthenesSieve(limit);
            long sum = 0;
            for (int i = 2; i < sieve.Length; i++)
            {
                if (!sieve[i])
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
