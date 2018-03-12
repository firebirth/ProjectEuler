namespace ProjectEuler.Utils
{
    public static class PalindromeHelper
    {
        public static bool IsPalindrome(int number)
        {
            var origNumber = number;
            var reversed = 0;
            do
            {
                var tmp = number % 10;
                reversed = reversed * 10 + tmp;
                number /= 10;
            } while (number > 0);

            return reversed == origNumber;
        }
    }
}
