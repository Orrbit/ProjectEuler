using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Problems.LargestPrimeFactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.LargestPrimeFactor.Tests
{
    [TestClass()]
    public class NaiveLargestPrimeFactorTests
    {
        [TestMethod()]
        public void SolveTest()
        {
            var solver = new NaiveLargestPrimeFactor();

            var solution = solver.Solve();

            Assert.AreEqual(6857, solution);
        }
    }
}