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
    public class ArraysTests
    {
        [TestMethod()]
        public void rotLeftTest_d4()
        {
            var a = new int[] { 1, 2, 3, 4, 5 };
            var d = 4;

            var rotatedArray = ArrayProblems.rotLeft(a, d);

            CollectionAssert.AreEqual(rotatedArray, new int[] { 5, 1, 2, 3, 4 });
        }

        [TestMethod()]
        public void rotLeftTest_d6()
        {
            var a = new int[] { 1, 2, 3, 4, 5 };
            var d = 6;

            var rotatedArray = ArrayProblems.rotLeft(a, d);

            CollectionAssert.AreEqual(rotatedArray, new int[] { 2, 3, 4, 5, 1 });
        }
        [TestMethod()]
        public void hourglassSumTest_exampleInput()
        {
            var arr = new int[7,6] { { 1,1,1,0,0,0 },
                { 0,1,0,0,0,0},
                { 0,1,0,0,0,0},
                { 1,1,1,0,0,0},
                { 0,0,2,4,4,0},
                { 0,0,0,2,0,0},
                { 0,0,1,2,4,0}
            };

            var max = ArrayProblems.hourglassSum(arr);

            Assert.AreEqual(max, 19);
        }

        [TestMethod()]
        public void hourglassSumTest_simpleInput()
        {
            var arr = new int[3,3] 
            { 
                { 1,1,1 },
                { 0,1,0 },
                { 1,1,1 }
            };

            var max = ArrayProblems.hourglassSum(arr);

            Assert.AreEqual(max, 7);
        }
        [TestMethod()]
        public void minimumBribes_firstExample()
        {
            int[] finalArray = new int[] { 2, 1, 5, 3, 4 };

            var minimumSwaps = ArrayProblems.minimumBribes(finalArray);

            Assert.AreEqual(3, minimumSwaps);
        }
        [TestMethod()]
        public void minimumBribes_secondExample()
        {
            int[] finalArray = new int[] { 2, 5, 1, 3, 4 };

            var minimumSwaps = ArrayProblems.minimumBribes(finalArray);

            Assert.AreEqual(-1, minimumSwaps);
        }
        [TestMethod()]
        public void minimumBribes_testCase2()
        {
            int[] finalArray = new int[] { 1, 2, 5, 3, 7, 8, 6, 4 };

            var minimumSwaps = ArrayProblems.minimumBribes(finalArray);

            Assert.AreEqual(7, minimumSwaps);
        }


    }
}