using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HankerRankSolutions
{
    public static class ArrayProblems
    {

        // Complete the rotLeft function below.
        public static int[] rotLeft(int[] a, int d)
        {
            var arrayLength = a.Length;
            int dModulated = d % arrayLength;
            var newArray = new int[arrayLength];
            int newIndex = (arrayLength - dModulated) % arrayLength;
            for (int i = 0; i < arrayLength; i++)
            {
                newArray[(newIndex+i)%arrayLength] = a[i];
            }
            return newArray;
        }

        public static void ArrayRotation()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            int[] result = rotLeft(a, d);

            textWriter.WriteLine(string.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();

        }
    }
}
