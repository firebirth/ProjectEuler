using System.Numerics;

namespace ProjectEuler.Tasks
{
    public static class Problem26
    {
        public static (int,int) Calculate()
        {
            int maxCycleLength = 0, currentMax = 0;
            for (var n = 3; n < 1000; n+=2)
            {
                int remainder = 1;
                for (var i = 0; i < n; i++)
                {
                    remainder = remainder * 10 % n;
                }

                var r0 = remainder;
                var cycleLength = 0;

                do
                {
                    remainder = remainder * 10 % n;
                    cycleLength++;
                } while (remainder != r0);

                if (cycleLength > maxCycleLength)
                {
                    currentMax = n;
                    maxCycleLength = cycleLength;
                }
            }
            return (maxCycleLength, currentMax);
        }
    }
}
