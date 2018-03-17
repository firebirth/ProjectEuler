using System.Linq;

namespace ProjectEuler.Tasks
{
    public static class Problem15
    {
        public static long GetPathCountForGrid(int gridSize)
        {
            // path count in a grid n*m is a binomial coeficient: m+n choose n
            // here m+n is 2*n
            return Enumerable.Range(1, gridSize)
                             .Aggregate((long)1, (curr, next) => curr * (gridSize + next) / next);
        }
    }
}
