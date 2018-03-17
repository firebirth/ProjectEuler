using System;

namespace ProjectEuler.Utils
{
    public static class NumberHelpers
    {
        public static long Gcd(long x, long y)
        {
            if (x == 0)
            {
                return y;
            }

            if (y == 0)
            {
                return x;
            }

            x = x % y;
            return Gcd(y, x);
        }

        private static readonly string[] SingleDigit =
            {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        private static readonly string[] Teens =
        {
            "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
        };

        private static readonly string[] Tens =
        {
            "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
        };

        public static string GetWordRepresentation(int number)
        {
            if (number > 1000)
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }

            if (number < 10)
            {
                return SingleDigit[number];
            }

            if (number < 20)
            {
                return Teens[number % 10];
            }

            if (number < 100)
            {
                var result = $"{Tens[number / 10]}";
                var remainder = number % 10;
                if (remainder > 0)
                {
                    result += $" {GetWordRepresentation(remainder)}";
                }
                return result;
            }

            if (number < 1000)
            {
                var result = $"{SingleDigit[number / 100]} hundred";
                var remainder = number % 100;
                if (remainder > 0)
                {
                    result += $" and {GetWordRepresentation(remainder)}";
                }

                return result;
            }

            return "one thousand";
        }
    }
}