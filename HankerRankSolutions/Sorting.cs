using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HankerRankSolutions
{
    public static class SortingProblems
    {

        //Solution for toys and mark
        public static int maximumToys(int[] prices, int k)
        {
            int toysCount = 0;

            QuickSort(prices, 0, prices.Length-1);

            int totalPrice = 0;

            while (totalPrice <= k)
            {
                totalPrice += prices[toysCount];
                if (totalPrice < k)             {
                    toysCount++;
                }
            }

            return toysCount;

        }

        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            else
            {
                int pivot = arr[(left+right) / 2];
                int index = Partition(arr, left, right, pivot);
                QuickSort(arr, left, index - 1);
                QuickSort(arr, index, right);
            }
        }

        public static int Partition(int[] arr, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left <= right) 
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
            }
            return left;

        }
    }
}
