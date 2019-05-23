using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HankerRankSolutions
{
    public static class AlgorithmProblems
    {
        //solution for A Very Big Sum
        public static long aVeryBigSum(long[] ar)
        {
            long sum = 0;
            foreach (var number in ar)
            {
                sum += number;
            }
            return sum;
        }

    }
}
