using Microsoft.VisualStudio.TestTools.UnitTesting;
using HankerRankSolutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HankerRankSolutions.Tests
{
    [TestClass()]
    public class AlgorithmProblemsTests
    {
        [TestMethod()]
        public void aVeryBigSumTest()
        {
            var array = new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };

            var results = AlgorithmProblems.aVeryBigSum(array);
            Assert.AreEqual(5000000015, results);
        }
    }
}