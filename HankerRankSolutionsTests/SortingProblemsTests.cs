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
    public class SortingProblemsTests
    {
        [TestMethod()]
        public void maximumToysTest_SampleOne()
        {
            int totalMoney = 50;
            var toyPrices = new int[] { 1, 12, 5, 111, 200, 1000, 10 };

            var results = SortingProblems.maximumToys(toyPrices, totalMoney);
            Assert.AreEqual(4, results);
        }
        [TestMethod()]
        public void maximumToysTest_SampleTwo()
        {
            int totalMoney = 7;
            var toyPrices = new int[] { 1, 2, 3, 4 };

            var results = SortingProblems.maximumToys(toyPrices, totalMoney);
            Assert.AreEqual(3, results);
        }
        [TestMethod()]
        public void maximumToysTest_SampleThree()
        {
            int totalMoney = 15;
            var toyPrices = new int[] { 3, 7, 2, 9, 4 };

            var results = SortingProblems.maximumToys(toyPrices, totalMoney);
            Assert.AreEqual(3, results);
        }
    }
}