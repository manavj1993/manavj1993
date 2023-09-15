using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice.Algorithms
{
    public class SortingAlgorithms
    {
        public static void IterativeMethodSorting()
        {
            int[] arr = new int[] { 15, 5, 3, 67, 21, 34, 12 }; 
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

            Console.WriteLine(String.Join(",", arr)); //Answer should be 3,5,12,15,21,34,67
        }

        public static void BubbleSort()
        {
            int[] arr = new int[] { 15, 5, 3, 67, 21, 34, 12 };
            int length = arr.Length;
            bool isBubblingCompleted = false;

            while (!isBubblingCompleted)
            {
                isBubblingCompleted = true;
                for (int i = 0; i < length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        var temp = arr[i];
                        arr[i] = arr[i+1];
                        arr[i + 1] = temp;
                        isBubblingCompleted = false;
                    }
                }
                length--; //Length should be decreased coz with each while loop, the last value will be the biggest hence removing it from the sort
            }
            Console.WriteLine(String.Join(",", arr)); //Answer should be 3,5,12,15,21,34,67
        }

        public static void QuickSort()
        {
            int[] arr = { 8, 2, 4, 7, 1, 3, 9, 6, 5 };
            QuickSortRecursion(arr, 0, arr.Length - 1);
            Console.WriteLine(String.Join(",", arr));
        }

        private static void QuickSortRecursion(int[] arr, int startindex, int endindex)
        {
            if (endindex <= startindex)
                return;

            int pivot = Partition(arr, startindex, endindex);
            QuickSortRecursion(arr, startindex, pivot - 1);
            QuickSortRecursion(arr, pivot + 1, endindex);
        }
        private static int Partition(int[] arr, int startindex, int endindex)
        {
            int i = startindex - 1;
            for (int j = startindex; j <= arr.Length - 1; j++)
            {
                if (arr[j] < arr[endindex])
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }   
            }
            i++;
            int temp2 = arr[i];
            arr[i] = arr[endindex];
            arr[endindex] = temp2;
            return i;
        }
    }
}