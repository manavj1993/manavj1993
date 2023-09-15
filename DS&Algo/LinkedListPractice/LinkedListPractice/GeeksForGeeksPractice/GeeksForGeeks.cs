using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkedListPractice.GeeksForGeeksPractice
{
    public static class GeeksForGeeks
    {
        /*Given two strings, find the length of longest subsequence present in both of them.Both the strings are in uppercase latin alphabets
        Example 1:

        Input:
        A = 6, B = 6
        str1 = ABCDGH
        str2 = AEDFHR
        Output: 3
        Explanation: LCS for input strings “ABCDGH” and “AEDFHR” is “ADH” of length 3.
        Example 2:

        Input:
        A = 3, B = 2
        str1 = ABC
        str2 = AC
        Output: 2
        Explanation: LCS of "ABC" and "AC" is "AC" of length 2. */
        public static void LongestCommonSubsequence(int x, int y, string s1, string s2)
        {
            int[,] dp = new int[x + 1, y + 1];

            //Following steps build dp[x+1][y+1] in bottom up fashion. Note that 
            //dp[i][j] contains length of LCS of s1[0..i-1] and s2[0..j-1].
            for (int i = 0; i <= x; i++)
            {
                for (int j = 0; j <= y; j++)
                {
                    //if i or j is 0, we mark dp[i][j] as 0.
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 0;
                    }

                    //else if the current char in both strings are equal, we add 1 
                    //to the output we got without including these both characters.
                    else if (s1[i - 1] == s2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }

                    //else s1[i-1]!=s2[j-1] so we check the max output which 
                    //comes from s1 or s2 without considering current character.
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }

                }
            }
            Console.WriteLine("Count is " + dp[x, y]);
        }

        public static void HasThreeIntegersWithSum()
        {
            int[] arr = { 1, 4, 12, 10, 8, 6 };
            int targetSum = 22;

            bool result = HasThreeIntegersWithSumLogic(arr, targetSum);

            Console.WriteLine("Array contains three integers with sum " + targetSum + ": " + result);
        }

        private static bool HasThreeIntegersWithSumLogic(int[] arr, int targetSum)
        {
            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 2; i++)
            {
                int left = i + 1;
                int right = arr.Length - 1;

                while (left < right)
                {
                    var currentSum = arr[i] + arr[left] + arr[right];
                    if (currentSum == targetSum)
                        return true;

                    else if (currentSum < targetSum)
                        left++;

                    else
                        right--;
                }
            }
            return false;
        }

        /*Given an array of positive numbers and a positive number ‘k’,
        find the maximum sum of any contiguous subarray of size ‘k’*/
        public static void FindMaxSumSubArray()
        {
            int[] arr = { 2, 1, 5, 1, 3, 2 };
            int k = 3;

            int maxSum = FindMaxSumSubarrayLogic(arr, k);
            Console.WriteLine("Maximum Sum of Subarray of Size " + k + ": " + maxSum);
        }

        private static int FindMaxSumSubarrayLogic(int[] arr, int k)
        {
            if (arr != null && arr.Length > k && k > 0)
                throw new ArgumentException("Invalid Input");

            int currentSum = 0;
            int maxSum = 0;

            for (int i = 0; i < k; i++)
            {
                currentSum += arr[i];
            }
            maxSum = currentSum;

            for (int i = k; i < arr.Length; i++)
            {
                currentSum = currentSum + arr[i] - arr[i - k]; //Add the next element while also removing the first element
                maxSum = Math.Max(maxSum, currentSum);
            }
            return maxSum;
        }

        /* You are given an unordered array consisting of consecutive integers  [1, 2, 3, ..., n] without any duplicates.
        You are allowed to swap any two elements.
        Find the minimum number of swaps required to sort the array in ascending order. */
        public static void FindMinSwapsToSort()
        {
            int[] arr = { 7, 1, 3, 2, 4, 5, 6 };
            int minSwaps = FindMinSwapsToSortLogic(arr);

            Console.WriteLine("Minimum Swaps to Sort: " + minSwaps);
        }

        private static int FindMinSwapsToSortLogic(int[] arr)
        {
            int n = arr.Length;
            int swaps = 0;

            for (int i = 0; i < n; i++)
            {
                // Continue if the element is already in its correct position
                while (arr[i] != i + 1)
                {
                    // Swap the current element with the element at its correct position
                    int temp = arr[i];
                    arr[i] = arr[temp - 1];
                    arr[temp - 1] = temp;

                    swaps++;
                }
            }

            return swaps;
        }
    }

    public class QueueUsingStacks<T>
    {
        private Stack<T> H1; // Main stack for enqueue operations
        private Stack<T> H2; // Temporary stack for dequeue operations

        public QueueUsingStacks()
        {
            H1 = new Stack<T>();
            H2 = new Stack<T>();
        }

        public void Enqueue(T item)
        {
            H1.Push(item);
        }

        public T Dequeue()
        {
            if (H2.Count == 0)
            {
                while (H1.Count > 0)
                {
                    H2.Push(H1.Pop());
                }
            }

            if (H2.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return H2.Pop();
        }

        public int Count
        {
            get { return H1.Count + H2.Count; }
        }
    }
}