using FluentAssertions;
using Xunit;

namespace ProjectEuler.Utils.Tests
{
    public class PrimeHelpersTests
    {
        [Theory]
        [InlineData(8051, new long[] {97, 83})]
        [InlineData(10403, new long[] {101, 103})]
        [InlineData(12, new long[] {2, 2, 3})]
        [InlineData(90, new long[] {2, 3, 3, 5})]
        [InlineData(6125, new long[] {7, 7, 5, 5, 5})]
        [InlineData(271, new long[0])]
        [InlineData(600851475143, new long[] {71, 839, 1471, 6857})]
        public void GetNonTrivialPrimeFactors_should_generate_non_trivial_divisors(long number, long[] expectedDivisors)
        {
            var actualDivisors = PrimeHelpers.GetNonTrivialPrimeFactors(number);

            actualDivisors.Should().BeEquivalentTo(expectedDivisors);
        }

        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(1747, true)]
        [InlineData(2729, true)]
        [InlineData(3413, true)]
        [InlineData(1579, true)]
        [InlineData(2551, true)]
        [InlineData(6, false)]
        [InlineData(9, false)]
        [InlineData(6292, false)]
        [InlineData(7990, false)]
        public void IsPrime_should_return_true_only_for_primes(long number, bool expectedIsPrime)
        {
            var actualIsPrime = PrimeHelpers.IsPrime(number);

            actualIsPrime.Should().Be(expectedIsPrime);
        }

        [Theory]
        [InlineData(10, new[] {2, 3, 5, 7})]
        [InlineData(100, new[]
            {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97})]
        [InlineData(1000, new[]
        {
            2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103,
            107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223,
            227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347,
            349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463,
            467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, 607,
            613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743,
            751, 757, 761, 769, 773, 787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883,
            887, 907, 911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997
        })]
        public void GetPrimesUpTo_should_return_all_primes_up_to_limit(int limit, int[] expectedPrimes)
        {
            var actualPrimes = PrimeHelpers.GetPrimesUpTo(limit);

            actualPrimes.Should().BeEquivalentTo(expectedPrimes, opts => opts.WithStrictOrdering());
        }
    }
}
