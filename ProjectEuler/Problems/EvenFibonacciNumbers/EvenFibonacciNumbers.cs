using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.EvenFibonacciNumbers
{
    public class EvenFibonacciNumbers : ISolvable
    {
        public int Solve()
        {
            var prev = 1;
            var curr = 2;

            var limit = 4000000;

            var sum = curr;

            while (curr < limit)
            {
                var temp = curr + prev;
                if (temp % 2 == 0)
                    sum += temp;

                prev = curr;
                curr = temp;
            }

            return sum;
        }
    }
}
