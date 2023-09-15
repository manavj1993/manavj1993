using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static void MainFunction()
        {
            //int numCount = Convert.ToInt32(Console.ReadLine().Trim());

            //int[] nums = new int[numCount];

            //for (int i = 0; i < numCount; i++)
            //{
            //    int posItem = Convert.ToInt32(Console.ReadLine().Trim());
            //    nums.Append(posItem);
            //}

            //int m = Convert.ToInt32(Console.ReadLine().Trim());

            int[] nums4 = { 4, 5, 6, 7, 8, 1, 2, 3 };
            int target4 = 8;
            int result4 = SearchInRotatedArray(nums4, target4);
            // Output: 4 (Element 8 is found at index 4)


            Console.WriteLine(result4);
        }
    }
}