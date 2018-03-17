using System;
using ProjectEuler.Tasks;

namespace ProjectEuler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Out.WriteLine(Problem14.LongestCollatzSequenceLengthStartingFromUnder(1000000));
            Console.ReadLine();
        }
    }
}
