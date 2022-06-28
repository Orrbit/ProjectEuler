using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.LargestPrimeFactor
{
    public class NaiveLargestPrimeFactor
    {
        private HashSet<long> _knownPrimes = new HashSet<long>();

        [Benchmark]
        public long Solve()
        {
            return LargestPrime(600851475143);
        }

        private long LargestPrime(long num)
        {
            long largestPrime = 1;
            var lowestFactor = Math.Floor(Math.Sqrt(num));

            for (long i = 2; i <= lowestFactor; i++)
            {
                if (IsFactor(num, i) && IsPrime(i))
                    largestPrime = i;
            }
            return largestPrime;
        }

        /// <summary>
        /// Simple primarlity test by trial division
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private bool IsPrime(long num)
        {
            if (_knownPrimes.Contains(num))
                return true;
            
            var lowestFactor = Math.Floor(Math.Sqrt(num));
            for (int i = 2; i <= lowestFactor; i++)
            {
                if(IsPrime(i) && IsFactor(num, i))
                {
                    return false;
                }
            }
            _knownPrimes.Add(num);
            return true;
        }

        private bool IsFactor(long num, long i) => num % i == 0;
    }
}
