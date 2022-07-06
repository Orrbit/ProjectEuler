using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Problems.SmallestMultiple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.SmallestMultiple.Tests
{
    [TestClass()]
    public class ReduceSmallestMultipleTests
    {
        [TestMethod()]
        public void SolveTest()
        {
            var solver = new ReduceSmallestMultiple(new SimpleLcmStrategy());

            Assert.AreEqual(232792560, solver.Solve());
        }
    }
}