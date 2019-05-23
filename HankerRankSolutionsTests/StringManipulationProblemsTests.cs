﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using HankerRankSolutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HankerRankSolutions.Tests
{
    [TestClass()]
    public class StringManipulationProblemsTests
    {
        [TestMethod()]
        public void alternatingCharactersTest_SampleOne()
        {
            string s = "AAAA";
            var results = StringManipulationProblems.alternatingCharacters(s);
            Assert.AreEqual(3, results);
        }
        [TestMethod()]
        public void alternatingCharactersTest_SampleTwo()
        {
            string s = "BBBBB";
            var results = StringManipulationProblems.alternatingCharacters(s);
            Assert.AreEqual(4, results);
        }
        [TestMethod()]
        public void alternatingCharactersTest_SampleThree()
        {
            string s = "ABABABAB";
            var results = StringManipulationProblems.alternatingCharacters(s);
            Assert.AreEqual(0, results);
        }
        [TestMethod()]
        public void alternatingCharactersTest_SampleFour()
        {
            string s = "BABABA";
            var results = StringManipulationProblems.alternatingCharacters(s);
            Assert.AreEqual(0, results);
        }
        [TestMethod()]
        public void alternatingCharactersTest_SampleFive()
        {
            string s = "AAABBB";
            var results = StringManipulationProblems.alternatingCharacters(s);
            Assert.AreEqual(4, results);
        }

        [TestMethod()]
        public void substrCountTest_SampleZero()
        {
            string s = "asasd";
            var results = StringManipulationProblems.substrCount(s.Length, s);
            Assert.AreEqual(7, results);
        }
        [TestMethod()]
        public void substrCountTest_SampleOne()
        {
            string s = "abcbaba";
            var results = StringManipulationProblems.substrCount(s.Length, s);
            Assert.AreEqual(10, results);
        }
        [TestMethod()]
        public void substrCountTest_SampleTwo()
        {
            string s = "aaaa";
            var results = StringManipulationProblems.substrCount(s.Length, s);
            Assert.AreEqual(10, results);
        }
        [TestMethod()]
        public void substrCountTest_SampleThree()
        {
            string s = "mnonopoo";
            var results = StringManipulationProblems.substrCount(s.Length, s);
            Assert.AreEqual(12, results);
        }
        [TestMethod()]
        public void substrCountTest_SampleFour()
        {
            string s = "aabaa";
            var results = StringManipulationProblems.substrCount(s.Length, s);
            Assert.AreEqual(9, results);
        }
    }
}