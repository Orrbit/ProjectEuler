using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.SmallestMultiple
{
    /// <summary>
    /// Hinges on the observation that
    /// LCM(a,b,c) = LCM(LCM(a,b), c)
    /// </summary>
    public class ReduceSmallestMultiple
    {
        private ILcmStrategy _lcmStrategy;
        public ReduceSmallestMultiple(ILcmStrategy lcmStrategy)
        {
            _lcmStrategy = lcmStrategy;
        }

        public int Solve()
        {
            var nums = Enumerable.Range(1, 20);
            return nums.Aggregate((a, b) => _lcmStrategy.Lcm(a, b));
        }
    }
}
