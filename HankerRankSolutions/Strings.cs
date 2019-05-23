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

            int sameCharacterCount = 0;
            for (int i = 0; i < n; i++)
            {

                if (i == 0 || (i - 1 >= 0 && s[i - 1] == s[i]))
                {
                    sameCharacterCount++;
                }
                else
                {
                    palindromeCount += (sameCharacterCount * (sameCharacterCount + 1)) / 2;
                    sameCharacterCount = 1;
                    if (i - 2 >= 0 && s[i - 2] == s[i])
                    {
                        int rightIndex = i;
                        int leftIndex = i - 2;
                        sameCharacterCount = 0;
                        while (leftIndex >= 0 &&  rightIndex < n && s[rightIndex] == s[i] &&  s[leftIndex] == s[rightIndex])
                        {
                            palindromeCount++;
                            rightIndex++;
                            leftIndex--;
                            sameCharacterCount++;
                        }
                        i = rightIndex-1;
                    }
                    else
                    {
                        sameCharacterCount = 1;
                    }
                }
            }
            palindromeCount += (sameCharacterCount * (sameCharacterCount + 1)) / 2;
            return palindromeCount;
        }
    }
}
