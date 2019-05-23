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

        //solution for Special Palindrome Again
        public static long substrCount(int n, string s)
        {
            long palindromeCount = 0;

            int currentRun = 0;
            for (int i = 0; i < n; i++)
            {

                if (i == 0 || (i - 1 >= 0 && s[i - 1] == s[i]))
                {
                    currentRun++;
                }
                else
                {
                    palindromeCount += (currentRun * (currentRun + 1)) / 2;
                    currentRun = 1;
                    if (i - 2 >= 0 && s[i - 2] == s[i])
                    {
                        int rightIndex = i;
                        int leftIndex = i - 2;
                        currentRun = 0;
                        while (leftIndex >= 0 &&  rightIndex < n && s[rightIndex] == s[i] &&  s[leftIndex] == s[rightIndex])
                        {
                            palindromeCount++;
                            rightIndex++;
                            leftIndex--;
                            currentRun++;
                        }
                        i = rightIndex-1;
                    }
                    else
                    {
                        currentRun = 1;
                    }
                }
            }
            palindromeCount += (currentRun * (currentRun + 1)) / 2;
            return palindromeCount;
        }
    }
}
