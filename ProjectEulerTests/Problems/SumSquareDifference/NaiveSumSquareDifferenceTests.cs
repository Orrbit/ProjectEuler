using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Problems.SumSquareDifference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.SumSquareDifference.Tests
{
    [TestClass()]
    public class NaiveSumSquareDifferenceTests
    {
        [TestMethod()]
        public void SolveTest()
        {
            var solver = new NaiveSumSquareDifference();
            Assert.AreEqual(25164150, solver.Solve());
        }
    }
}