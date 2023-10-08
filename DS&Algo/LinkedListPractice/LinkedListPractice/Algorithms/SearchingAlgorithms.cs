using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LinkedListPractice.Algorithms
{
    public class SearchingAlgorithms
    {
        public static int BinarySearch(int[] A, int n, int key)
        {
            int l = 0;
            int r = n - 1;

            while (l <= r)
            { 
                int mid = (l + r) / 2;
                if (key == A[mid])
                    return mid;

                else if (key < A[mid])
                    r = mid - 1;
                else if(key > A[mid])
                    l = mid + 1;
            }
            return -1;
        }

        public static int BinarySearchRecursion(int[] A, int key, int left, int right)
        {
            if (left > right)
                return -1;

            else
            {
                int mid = (left + right) / 2;
                if (key == A[mid])
                    return mid;
                else if (key < A[mid])
                    return BinarySearchRecursion(A, key, left, mid - 1);
                else if (key > A[mid])
                    return BinarySearchRecursion(A, key, mid + 1, right);
            }
            return -1;
        }
    }

    //Problem: Search in Rotated Sorted Array
    public class SearchingAlgorithmsPractice
    {
        public static void MainFunction()
        {
            //Program 1 
            //int m = Convert.ToInt32(Console.ReadLine().Trim());

            //int[] nums4 = { 4, 5, 6, 7, 8, 1, 2, 3 };
            //int target4 = 8;
            //int result4 = SearchInRotatedArray(nums4, target4);
            //// Output: 4 (Element 8 is found at index 4)
            //Console.WriteLine(result4);
            //End Program 1

            //Program 2
            //int[] rotatedArray2 = { 134, 178, 13, 24, 34, 56, 57, 68, 78, 89, 90, 112 };
            //Console.WriteLine("Maximum: " + FindMax(rotatedArray2));
            //Console.WriteLine("Minimum: " + FindMin(rotatedArray2));
            //End Program 2

            //Program 3
            int[] test1 = { 134, 178, 13, 24, 34, 56, 57, 68, 78, 89, 90, 112 };
            int[] test2 = { 8, 9, 10, 11, 12, 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Test 1 - Second Max: " + FindSecondMax(test1) + ", Second Min: " + FindSecondMin(test1));
            Console.WriteLine("Test 1 - Second Max: " + FindSecondMax(test2) + ", Second Min: " + FindSecondMin(test2));
            //End program 3
        }

        #region Program 1: To find the index of an element in a rotated sorted array
        public static int SearchInRotatedArray(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            
            while(left <= right)
            {
                int mid = (left + right) / 2;
                if (target == nums[mid])
                    return mid;

                if (nums[left] <= nums[mid])
                {
                    if (nums[left] <= target && target < nums[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else
                {
                    if (target > nums[mid] && target <= nums[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }
            return -1;
        }


        #endregion

        #region Program 2: To find max and min element in a rotated sorted array

        //First find the pivot point at which the sorted array is rotated
        private static int FindRotationPoint2(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] > arr[right])
                    left = mid + 1;

                else
                    right = mid;
            }
            return left;
        }

        private static int FindMax(int[] arr)
        { 
            int pivot = FindRotationPoint2(arr);
            return arr[pivot - 1];
        }

        private static int FindMin(int[] arr)
        {
            int pivot = FindRotationPoint2(arr);
            return arr[(pivot)];
        }
        #endregion

        #region Program 3: To find 2nd max and 2nd min element in a rotated sorted array
        static int FindRotationPoint3(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] > arr[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return left;
        }

        static int FindSecondMax(int[] arr)
        {
            int pivot = FindRotationPoint3(arr);
            int max = arr[pivot];
            int secondMax = int.MinValue;

            for (int i = 0; i < pivot; i++)
            {
                if (arr[i] > max)
                {
                    secondMax = max;
                    max = arr[i];
                }
                else if (arr[i] > secondMax && arr[i] != max)
                {
                    secondMax = arr[i];
                }
            }

            return secondMax;
        }

        static int FindSecondMin(int[] arr)
        {
            int pivot = FindRotationPoint3(arr);
            int n = arr.Length;
            int min = arr[pivot];
            int secondMin = int.MaxValue;

            for (int i = pivot + 1; i < n; i++)
            {
                if (arr[i] < min)
                {
                    secondMin = min;
                    min = arr[i];
                }
                else if (arr[i] < secondMin && arr[i] != min)
                {
                    secondMin = arr[i];
                }
            }

            return secondMin;
        }
        #endregion
    }
}