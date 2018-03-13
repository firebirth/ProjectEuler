namespace ProjectEuler.Tasks
{
    public static class Problem5
    {
        public static int GetSmallestEvenlyDivisibleByAllUpTo(int maxValue)
        {
            for (int i = maxValue; i < int.MaxValue; i++)
            {
                var wasDivisible = true;
                for (int j = 2; j <= maxValue; j++)
                {
                    if (i % j != 0)
                    {
                        wasDivisible = false;
                        break;
                    }
                }

                if (wasDivisible)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
