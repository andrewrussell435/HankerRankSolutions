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

        //solution for 2D Array - DS
        public static int hourglassSum(int[,] arr)
        {
            int maxSum = int.MinValue;

            int numOfRows = arr.GetLength(0);
            int numOfColumns = arr.GetLength(1);

            for (int i = 0; i < numOfColumns; i++)
            {
                for (int j = 0; j < numOfRows; j++)
                {
                    if (i-1 >=0 && i+1 < numOfColumns)
                    {
                        if (j-1 >= 0 && j+1 < numOfRows)
                        {
                            int sum = arr[j - 1, i - 1]
                                + arr[j - 1, i]
                                + arr[j - 1, i + 1]
                                + arr[j, i]
                                + arr[j + 1, i - 1]
                                + arr[j + 1, i]
                                + arr[j + 1, i + 1];
                            if (sum > maxSum)
                            {
                                maxSum = sum;
                            }
                        }
                    }
                }
            }

            return maxSum;
        }
        //Solution for New Year Chaos
        public static int minimumBribes(int[] q)
        {
            int[] swappedArray = new int[q.Length];
            int[] currentIndexForPerson = new int[q.Length];
            int[] swapCounter = new int[q.Length];
            for (int i = 0; i < q.Length; i++)
            {
                swappedArray[i] = i + 1;
                swapCounter[i] = 0;
                currentIndexForPerson[i] = i;
            }
            int maxNumberOfBribesPerPerson = 2;
            int minumumNumberOfSwaps = 0;

            for (int i = q.Length - 1; i > 0; i--)
            {

                int initialPerson = swappedArray[i];
                int personInIndexAtFinalPosition = q[i];
                if (initialPerson != personInIndexAtFinalPosition)
                {
                    int currentIndex = currentIndexForPerson[personInIndexAtFinalPosition -1]+1;
                    while (currentIndex < q.Length && swapCounter[swappedArray[currentIndex]-1] < maxNumberOfBribesPerPerson && q[i] != swappedArray[i])
                    {
                        int temp = swappedArray[currentIndex];
                        swappedArray[currentIndex] = swappedArray[currentIndex - 1];
                        currentIndexForPerson[swappedArray[currentIndex] - 1] = currentIndex;
                        swappedArray[currentIndex - 1] = temp;
                        currentIndexForPerson[temp - 1] = currentIndex - 1;
                        swapCounter[temp-1]++;
                        minumumNumberOfSwaps++;
                        currentIndex++;
                    }
                    if (q[i] != swappedArray[i])
                    {
                        minumumNumberOfSwaps = -1;
                        break;
                    }
                }

            }

            if (minumumNumberOfSwaps >= 0)
            {
                Console.WriteLine(minumumNumberOfSwaps);
            }
            else
            {
                Console.WriteLine("Too chaotic");

            }
            return minumumNumberOfSwaps;
        }
    }
}
