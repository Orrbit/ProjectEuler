using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.LargestPalindromeProduct
{
    public class ReducedIterationsLargestPalindromeProduct
    {
        /// <summary>
        /// Returns the laargest palindromee made from the product of two
        /// 3 digit numbers. 
        /// Greatest product of two 3 digit numbers is 1 million.
        /// </summary>
        /// <returns></returns>
        [Benchmark]
        public int Solve()
        {
            var largest = 0;
            for(int i = 999; i >= 100; i--)
            {
                for(int j = 999; j >= i; j--)
                {
                    var prod = i * j;
                    if (prod > largest && LargestPalindromeProductUtilities.IsNumericalPalindrome(prod))
                        largest = prod;
                }
            }
            return largest;
        }             
    }
}
