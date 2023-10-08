using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                        arr[i] = arr[i + 1];
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


        //Write a C# program to sort a list of strings using the Quick Sort algorithm.
        public static void QuickSortString()
        {
            string[] names = new string[] { "John", "Alice", "Bob", "Eve", "Charlie" };
            QSAlgo(names, 0, names.Length - 1);
            Console.WriteLine(string.Join(',', names));
        }

        public static void QSAlgo(string[] arr, int startindex, int endindex)
        {
            if (endindex <= startindex)
                return;

            int pivot = Partitions(arr, startindex, endindex);
            QSAlgo(arr, startindex, pivot - 1);
            QSAlgo(arr, pivot + 1, endindex);
        }

        private static int Partitions(string[] arr, int startindex, int endindex)
        {
            int i = startindex - 1;
            for (int j = startindex; j <= endindex - 1; j++)
            {
                if (string.Compare(arr[j], arr[endindex], StringComparison.OrdinalIgnoreCase) < 0)
                {
                    i++;
                    string temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            i++;
            (arr[endindex], arr[i]) = (arr[i], arr[endindex]);
            return i;
        }


        //Merge Sort Algorithm
        public static void MergeSortMain()
        {
            int[] array = { 8, 2, 5, 3, 4, 7, 6, 1 };
            MergeSort(array);

            Console.WriteLine(String.Join(',', array));
        }

        private static void MergeSort(int[] arr)
        {
            int length = arr.Length;
            if (length <= 1)
                return;

            int middle = length / 2;
            int[] leftArray = new int[middle];
            int[] rightArray = new int[length - middle];

            int i = 0;
            int j = 0;

            for (; i < length; i++)
            { 
                if(i < middle)
                    leftArray[i] = arr[i];
                else
                {
                    rightArray[j] = arr[i];
                    j++;
                }    
            }
            MergeSort(leftArray);
            MergeSort(rightArray);
            Merge(leftArray, rightArray, arr);
        }

        private static void Merge(int[] leftArray, int[] rightArray, int[] array)
        { 
            int leftSize = array.Length / 2;
            int rightSize = array.Length - leftSize;

            int i = 0, l = 0, r = 0; //Indices
            while (l < leftSize && r < rightSize)
            {
                if (leftArray[l] < rightArray[r])
                {
                    array[i] = leftArray[l];
                    i++;
                    l++;
                }
                else
                {
                    array[i] = rightArray[r];
                    i++;
                    r++;
                }
            }
            while (l < leftSize)
            {
                array[i] = leftArray[l];
                i++;
                l++;
            }
            while (r < rightSize)
            {
                array[i] = rightArray[r];
                i++;
                r++;
            }
        }
    }
}