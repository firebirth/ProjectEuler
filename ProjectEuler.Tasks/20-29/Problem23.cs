using ProjectEuler.Utils;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Tasks
{
    public static class Problem23
    {
        private const int UpperLimit = 28123;

        public static int Calculate()
        {
            var abundantNumbers = GetAbundantNumbers().ToArray();
            var sums = abundantNumbers.SelectMany(x => abundantNumbers, (x, y) => (x, y))
                                      .Select(t => t.x + t.y)
                                      .Where(i => i <= UpperLimit)
                                      .Distinct();

            return Enumerable.Range(1, UpperLimit-1)
                             .Except(sums)
                             .Sum();
        }

        private static IEnumerable<int> GetAbundantNumbers()
        {
            for (int i = 1; i < UpperLimit; i++)
            {
                var factors = NumberHelpers.GetAllFactors(i);
                if (i < factors.Sum())
                {
                    yield return i;
                }
            }
        }
    }
}
