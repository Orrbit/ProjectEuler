using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.SmallestMultiple
{
    public class NaiveSmallestMultiple
    {
        public int Solve()
        {
            var testNum = 1;
            while (true)
            {
                for(int i = 1; i <= 20; i++)
                {
                    if (testNum % i != 0)
                        break;
                    if (i == 20)
                        return testNum;
                }
                testNum++;
            }
        }
    }
}
