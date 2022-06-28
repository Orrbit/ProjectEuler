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
    public class ReducedIterationsEvenFibNumbersTests
    {
        [TestMethod()]
        public void SolveTest()
        {
            var solver = new ReducedIterationsEvenFibNumbers();
            Assert.AreEqual(4613732, solver.Solve());
        }
    }
}