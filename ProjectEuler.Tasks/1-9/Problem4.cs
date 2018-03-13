using System;
using System.Linq;
using ProjectEuler.Utils;

namespace ProjectEuler.Tasks
{
    public static class Problem4
    {
        public static int GetLargestPalindrome(int digits)
        {
            var from = (int) Math.Pow(10, digits - 1);
            var to = (int) (Math.Pow(10, digits) - 1);
            var numbers = Enumerable.Range(from, to - from + 1).ToArray();

            var products = numbers.SelectMany(i => numbers.Select(j => i * j));

            return products.Where(PalindromeHelper.IsPalindrome).Max();
        }
    }
}
