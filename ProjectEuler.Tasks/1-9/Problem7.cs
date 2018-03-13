using ProjectEuler.Utils;

namespace ProjectEuler.Tasks
{
    public static class Problem7
    {
        public static long GetPrimeNumber(int index)
        {
            int count = 2, i = 5; // 2 primes before 5
            while (true)
            {
                if (PrimeHelpers.IsPrime(i))
                {
                    count++;
                }

                if (count >= index)
                {
                    return i;
                }

                i += 2;
            }
        }
    }
}
