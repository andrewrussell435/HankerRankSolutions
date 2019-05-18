using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HankerRankSolutions
{
    public static class HashesProblems
    {
        // Complete the twoStrings function below.
        public static string twoStrings(string s1, string s2)
        {
            if (s1.Length > s2.Length) {
                return StringCompare(s1, s2);
            }
            else
            {
                return StringCompare(s2, s1);
            }
        }

        public static string StringCompare(string s1, string s2)
        {
            var s1Hash = new HashSet<char>(s1);

            for (int i = 0; i < s2.Length; i++)
            {
                if (s1Hash.Contains(s2[i]))
                {
                    return "YES";
                }
            }
            return "NO";
        }
    }
}