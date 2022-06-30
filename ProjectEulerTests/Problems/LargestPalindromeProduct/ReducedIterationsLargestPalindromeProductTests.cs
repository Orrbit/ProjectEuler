using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Problems.LargestPalindromeProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.LargestPalindromeProduct.Tests
{
    [TestClass()]
    public class ReducedIterationsLargestPalindromeProductTests
    {
        [TestMethod()]
        public void SolveTest()
        {
            var solver = new ReducedIterationsLargestPalindromeProduct();
            Assert.AreEqual(906609, solver.Solve());
        }
    }
}