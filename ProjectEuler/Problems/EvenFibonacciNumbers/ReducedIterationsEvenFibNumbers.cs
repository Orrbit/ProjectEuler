using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.EvenFibonacciNumbers
{
    public class ReducedIterationsEvenFibNumbers: ISolvable
    {
        /// <summary>
        /// This method makes use of the mathematical observation
        /// that even fibonacci numbers occur on a predictable basis.
        /// This is because of the fact that
        /// even + even = even
        /// odd + even = odd
        /// odd + odd = even
        /// 
        /// Look at the first couple numbers in the sequence
        /// 1, 2, 3, 5, 8, 13, 21, 34
        /// odd, even, odd, odd, even, odd, odd, even
        /// 
        /// We can observe the atomic pattern of odd, even, odd, which means
        /// we can eliminate conditional checks for 2/3 of numbers
        /// 
        /// </summary>
        /// <returns></returns>
        [Benchmark]
        public int Solve()
        {
            var prev = 1;
            var curr = 2;

            var limit = 4000000;
            var sum = curr;
            while(true)
            {
                var odd1 = prev + curr;
                var odd2 = odd1 + curr;

                prev = odd2;
                curr = odd1 + odd2;

                if (curr > limit)   //This branching point doesn't waste a lot of efficiency since it is predicted by the processor to be false majority of loops
                    break;
                sum += curr;
            }

            return sum;
        }
    }
}
