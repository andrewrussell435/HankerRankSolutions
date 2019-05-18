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
    public class HashesProblemsTests
    {
        [TestMethod()]
        public void twoStringsTest_Example1()
        {
            string s1 = "a";
            string s2 = "art";

            string results = HashesProblems.twoStrings(s1, s2);

            Assert.IsTrue("YES" == results);
        }
        [TestMethod()]
        public void twoStringsTest_Example2()
        {
            string s1 = "be";
            string s2 = "cat";

            string results = HashesProblems.twoStrings(s1, s2);

            Assert.IsTrue("NO" == results);
        }
        [TestMethod()]
        public void twoStringsTest_Example3()
        {
            string s1 = "hello";
            string s2 = "world";

            string results = HashesProblems.twoStrings(s1, s2);

            Assert.IsTrue("YES" == results);
        }
        [TestMethod()]
        public void twoStringsTest_Example4()
        {
            string s1 = "hi";
            string s2 = "world";

            string results = HashesProblems.twoStrings(s1, s2);

            Assert.IsTrue("NO" == results);
        }
    }
}