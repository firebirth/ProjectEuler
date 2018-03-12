using System;
using System.Linq;

namespace ProjectEuler.Tasks
{
    public static class Problem1
    {
        public static long GetSumBelow1000()
        {
            var numbers = Enumerable.Range(1, 999).Select(i => (long) i).ToArray();

            var multiplesOf3 = numbers.Where(i => i % 3 == 0);
            var multiplesOf5 = numbers.Where(i => i % 5 == 0);

            return multiplesOf3.Concat(multiplesOf5).Distinct().Sum();
        }
    }
}
