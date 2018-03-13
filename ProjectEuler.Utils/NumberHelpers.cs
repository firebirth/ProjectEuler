namespace ProjectEuler.Utils
{
    public static class NumberHelpers
    {
        public static long Gcd(long x, long y)
        {
            if (x == 0)
            {
                return y;
            }

            if (y == 0)
            {
                return x;
            }

            x = x % y;
            return Gcd(y, x);
        }
    }
}