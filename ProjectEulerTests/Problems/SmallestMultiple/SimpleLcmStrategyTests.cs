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
    public class SimpleLcmStrategyTests
    {
        private SimpleLcmStrategy strat;

        [TestInitialize()]
        public void Init()
        {
            strat = new SimpleLcmStrategy();
        }

        [TestMethod()]
        public void LcmTest()
        {
            Assert.AreEqual(21, strat.Lcm(3, 7));
        }

        [TestMethod()]
        public void LcmTestHigh()
        {
            Assert.AreEqual(10, strat.Lcm(5, 10));
        }

        [TestMethod()]
        public void LcmTestSame()
        {
            Assert.AreEqual(3, strat.Lcm(3, 3));
        }
    }
}