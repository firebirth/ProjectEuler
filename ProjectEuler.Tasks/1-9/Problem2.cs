using System.Linq;
using ProjectEuler.Utils;

namespace ProjectEuler.Tasks
{
    public static class Problem2
    {
        public static long GetSumOfEvenFibonacci(long limit)
        {
            var sequence = FibonacciHelper.GetFibonacciSequenceUpTo(limit);

            return sequence.Where(i => i % 2 == 0).Sum();
        }
    }
}
