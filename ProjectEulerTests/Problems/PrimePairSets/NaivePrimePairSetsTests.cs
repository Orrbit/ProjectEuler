using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Problems.PrimePairSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.PrimePairSets.Tests
{
    [TestClass()]
    public class NaivePrimePairSetsTests
    {
        [TestMethod()]
        public void SolveTest()
        {
            NaivePrimePairSets solver = new NaivePrimePairSets(new TrialDivisionPrimalityTest());

            Assert.AreEqual(26033, solver.Solve());
        }
    }
}