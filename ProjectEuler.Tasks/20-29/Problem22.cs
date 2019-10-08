using System.IO;
using System.Linq;

namespace ProjectEuler.Tasks
{
    public static class Problem22
    {
        public static long Calculate(string filename)
        {
            return File.ReadAllText(filename)
                       .Split(',')
                       .OrderBy(s => s)
                       .Select((l, i) => (line: l.Trim('"'), index: i + 1))
                       .Aggregate(0, (curr, t) => curr + GetNameValue(t.line) * t.index);
        }

        private static int GetNameValue(string name)
        {
            const int letterShift = 'A' - 1;
            return name.Aggregate(0, (curr, c) => curr + c - letterShift);
        }
    }
}
