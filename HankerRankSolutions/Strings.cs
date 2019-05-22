using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HankerRankSolutions
{
    public static class StringManipulationProblems
    {
        //solution for Alternating Characters
        public static int alternatingCharacters(string s)
        {
            int deletionCount = 0;

            char lastChar = '0';
            foreach (var c in s)
            {
                if (c != lastChar)
                {
                    lastChar = c;
                }
                else
                {
                    deletionCount++;
                }
            }

            return deletionCount;

        }
    }
}
