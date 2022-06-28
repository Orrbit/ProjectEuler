using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Problems.EvenFibonacciNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.EvenFibonacciNumbers.Tests
{
    [TestClass()]
    public class NaiveEvenFibNumbersTests
    {
        [TestMethod()]
        public void SolveTest()
        {
            var solver = new NaiveEvenFibNumbers();
            Assert.AreEqual(4613732, solver.Solve());
        }
    }
}