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
        //Solution for two strings
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
        //helper for two strings
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

        //solution for Hash Tables: Ransom Note
        public static bool checkMagazine(string[] magazine, string[] note)
        {
            Dictionary<string, int> magazineWordCountDict = GetWordCountDict(magazine);

            bool valid = true;
            foreach (string word in note)
            {
                if (magazineWordCountDict.ContainsKey(word) && magazineWordCountDict[word] > 0)
                {
                    magazineWordCountDict[word]--;
                }
                else
                {
                    valid = false;
                    break;
                }

            }

            var results = valid ? "Yes" : "No";
            Console.WriteLine(results);
            return valid;
        }

        //helper for Hash Tables: Random's checkMagazine()
        public static Dictionary<string, int> GetWordCountDict(string[] magazine)
        {
            Dictionary<string, int> magazineWordCountDict = new Dictionary<string, int>();
            foreach (string s in magazine)
            {
                if (magazineWordCountDict.ContainsKey(s))
                {
                    magazineWordCountDict[s]++;
                }
                else
                {
                    magazineWordCountDict.Add(s, 1);
                }
            }
            return magazineWordCountDict;
        }

        //solution for Sherlock and Anagrams
        public static int sherlockAndAnagrams(string s)
        {
            int anagramCount = 0;
            var substringDict = new Dictionary<string, int>();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = s.Length-i; j > 0; j--)
                {
                    var substring = s.Substring(i, j);
                    var sortedString = String.Concat(substring.OrderBy(c => c));
                    if (substringDict.ContainsKey(sortedString))
                    {
                        anagramCount+= substringDict[sortedString];
                        substringDict[sortedString]++;
                    }
                    else
                    {
                        substringDict.Add(sortedString, 1);
                    }
                }
            }
            return anagramCount;
        }
    }
}
