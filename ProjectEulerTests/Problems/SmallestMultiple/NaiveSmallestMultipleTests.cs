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
    public class NaiveSmallestMultipleTests
    {
        [TestMethod()]
        public void SolveTest()
        {
            var solver = new NaiveSmallestMultiple();
            Assert.AreEqual(232792560, solver.Solve());
        }
    }
}