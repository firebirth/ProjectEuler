using System.Linq;
using ProjectEuler.Utils;

namespace ProjectEuler.Tasks
{
    public static class Problem17
    {
        public static long GetLetterCount(int limit)
        {
            return Enumerable.Range(1, limit)
                             .Select(NumberHelpers.GetWordRepresentation)
                             .Select(s => s.Replace(" ", string.Empty))
                             .Aggregate(0, (curr, s) => curr + s.Length);
        }
    }
}
