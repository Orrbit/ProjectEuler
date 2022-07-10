using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.PrimePairSets
{
    public class NaivePrimePairSets
    {
        private IPrimalityTest _primalityTest;

        public NaivePrimePairSets(IPrimalityTest primalityTest)
        {
            _primalityTest = primalityTest;
        }

        public int Solve()
        {
            var lowestSum = Int32.MaxValue;
            var l = GetPrimes();
            var sets = GetAllFiveSets(l);
            return sets.Select(set => set.Sum()).Min();
        }

        private List<int> GetPrimes()
        {
            var l = new List<int>();
            for(int i = 1; i < 10000; i++)
            {
                if (_primalityTest.IsPrime(i))
                {
                    l.Add(i);
                }
            }
            return l;
        }

        private List<int[]> GetAllFiveSets(List<int> listIn)
        {
            var listOut = new List<int[]>();

            for(int a = 0; a < listIn.Count; a++)
            {
                var elA = listIn[a];
                for (int b = a+1; b < listIn.Count; b++)
                {
                    var elB = listIn[b];
                    if (!HasPrimeConcatProperty(elA, elB))
                        continue;
                    for (int c = b+1; c < listIn.Count; c++)
                    {
                        var elC = listIn[c];
                        if (!HasPrimeConcatProperty(elA, elC) || !HasPrimeConcatProperty(elB, elC))
                            continue;
                        for (int d = c+1; d < listIn.Count; d++)
                        {
                            var elD = listIn[d];
                            if (!HasPrimeConcatProperty(elA, elD) || !HasPrimeConcatProperty(elB, elD) || !HasPrimeConcatProperty(elC, elD))
                                continue;
                            for (int e = d+1; e < listIn.Count; e++)
                            {
                                var elE = listIn[e];
                                if (!HasPrimeConcatProperty(elA, elE) || !HasPrimeConcatProperty(elB, elE) || !HasPrimeConcatProperty(elC, elE) || !HasPrimeConcatProperty(elD, elE))
                                    continue;
                                listOut.Add(new int[] { elA, elB, elC, elD, elE });
                            }
                        }
                    }
                }
            }

            return listOut;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="set"></param>
        /// <returns></returns>
        private bool HasPrimeConcatProperty(int a, int b)
        {
            var concatFor = int.Parse(a.ToString() + b.ToString());
            var concatBack = int.Parse(b.ToString() + a.ToString());

            return _primalityTest.IsPrime(concatFor) && _primalityTest.IsPrime(concatBack);
        }

        
    }
}
