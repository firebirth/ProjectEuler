using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEuler.Tasks
{
    public static class Problem22
    {
        public static async Task<long> Calculate(string filename)
        {
            await SortFile(filename);
            var pos = 0;
            var result = 0L;
            using (var stream = File.OpenRead(filename))
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    pos++;
                    var line = await reader.ReadLineAsync();
                    result += GetNameValue(line) * pos;
                }
            }
            return result;
        }

        private static async Task SortFile(string filename)
        {
            var text = await File.ReadAllTextAsync(filename);
            var lines = text.Split(',').Select(s => s.Trim('"')).OrderBy(s => s).ToArray();
            await File.WriteAllLinesAsync(filename, lines);
        }

        private static int GetNameValue(string name)
        {
            int result = 0;
            foreach(var c in name)
            {
                result += c - ('A' + 1);
            }

            return result;
        }
    }
}
