using ProjectEuler.Utils;
using System.Linq;

namespace ProjectEuler.Tasks
{
    public static class Problem24
    {
        public static string Calculate()
        {
            return SequenceHelper.GenerateLexicographicPermutations('0', '1', '2', '3', '4', '5', '6', '7', '8', '9')
                                 .Skip(999_999)
                                 .First();
        }
    }
}
