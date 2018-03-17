using System.Linq;
using ProjectEuler.Utils;

namespace ProjectEuler.Tasks
{
    public static class Problem14
    {
        public static int LongestCollatzSequenceLengthStartingFromUnder(int startLimit)
        {
            var currentMax = (Start: 0, Length: 0);
            for (int i = startLimit - 1; i >= 1; i-=2)
            {
                // caching?
                var sequence = SequenceHelper.GetCollatzSequence(i);
                var count = sequence.Count();
                if (currentMax.Length < count)
                {
                    currentMax = (Start: i, Length: count);
                }
            }

            return currentMax.Start;
        }
    }
}
