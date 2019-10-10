using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Utils
{
    public static class SequenceHelper
    {
        public static long[] GetFibonacciSequenceUpTo(long limit)
        {
            const double k = 0.8047189562170501;
            const double logPhi = 0.48121182505960344;
            var listLengthLimit = (int) Math.Round((Math.Log(limit) + k) / logPhi, MidpointRounding.AwayFromZero);

            return GetFibonacciSequence()
                   .Take(listLengthLimit)
                   .Where(i => i < limit)
                   .ToArray();
        }

        public static IEnumerable<long> GetFibonacciSequence()
        {
            yield return 1;
            yield return 2;
            long i1 = 2, i2 = 1;
            while (true)
            {
                var acc = i1 + i2;
                i2 = i1;
                i1 = acc;
                yield return acc;
            }
        }

        public static IEnumerable<long> GetCollatzSequence(int number)
        {
            var current = (long) number;

            yield return current;

            while (current > 1)
            {
                if (current % 2 == 0)
                {
                    yield return current /= 2;
                }
                else
                {
                    yield return current = current * 3 + 1;
                }
            }
        }

        public static IEnumerable<string> GenerateLexicographicPermutations(params char[] alphabet)
        {
            alphabet = alphabet.OrderBy(c => c).ToArray();
            var size = alphabet.Length;
            while (true)
            {
                yield return new string(alphabet);
                int i;
                for (i = size - 2; i >= 0; --i)
                {
                    if (alphabet[i] < alphabet[i + 1])
                    {
                        break;
                    }
                }

                if (i == -1)
                {
                    break;
                }
                else
                {
                    var ceilIndex = FindCeil(alphabet, alphabet[i], i + 1, size - 1);
                    Swap(alphabet, i, ceilIndex);
                    Reverse(alphabet, i + 1, size - 1);
                }
            }

            int FindCeil(char[] str, char first, int l, int h)
            {
                // initialize index of ceiling element  
                var ceilIndex = l;
                var ceilChar = str[ceilIndex];
                // Now iterate through rest of the elements and find
                // the smallest character greater than 'first'
                for (var i = l + 1; i <= h; i++)
                {
                    var c = str[i];
                    if (c > first && c < ceilChar)
                    {
                        ceilIndex = i;
                        ceilChar = str[ceilIndex];
                    }
                }

                return ceilIndex;
            }

            void Swap<T>(T[] arr, int x, int y)
            {
                var tmp = arr[x];
                arr[x] = arr[y];
                arr[y] = tmp;
            }

            void Reverse<T>(T[] arr, int from, int to)
            {
                while (from < to)
                {
                    Swap(arr, from, to);
                    from++;
                    to--;
                }
            }
        }
    }
}
