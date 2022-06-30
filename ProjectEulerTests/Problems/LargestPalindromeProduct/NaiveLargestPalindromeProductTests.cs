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
    public class NaiveLargestPalindromeProductTests
    {
        [TestMethod()]
        public void SolveTest()
        {
            var solver = new NaiveLargestPalindromeProduct();
            Assert.AreEqual(906609, solver.Solve());
        }
    }
}