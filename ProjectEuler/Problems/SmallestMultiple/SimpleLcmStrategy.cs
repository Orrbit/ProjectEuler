using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.SmallestMultiple
{
    public class SimpleLcmStrategy : ILcmStrategy
    {

        [Benchmark]
        public int Lcm(int a, int b)
        {
            var higher = Math.Max(a, b);
            var lower = Math.Min(a, b);

            int lcm = higher;
            while(lcm % lower != 0)
            {
                lcm += higher;
            }
            return lcm;
        }
    }
}
