using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.SumSquareDifference
{
    public class NaiveSumSquareDifference
    {
        public int Solve()
        {
            int sumSquares = 0;
            int sum = 0;

            for(int i = 1; i <= 100; i++)
            {
                sumSquares += (int)Math.Pow(i,2);
                sum += i;
            }
            return (int)Math.Pow(sum, 2) - sumSquares;
        }
    }
}
