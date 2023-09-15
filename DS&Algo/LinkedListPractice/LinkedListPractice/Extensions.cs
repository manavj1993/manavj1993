using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    public static class Extensions
    {
        public static void ForEach<T>(this IEnumerable enumerable, Action<T> action)
        {
            foreach (T obj in enumerable)
            {
                action(obj);
            }
        }

        public static int[] ToIntArray(this int n)
        {
            if (n == 0) return new int[1] { 0 };
            var digits = new List<int>();
            for (; n != 0;)
            {
                digits.Add(n % 10);
                n /= 10;
            }

            var arr = digits.ToArray();
            Array.Reverse(arr);
            return arr;
        }

        public static bool IsGreaterThanOrEqualTo<T>(this T value, T other) where T : IComparable<T>
        {
            return value.CompareTo(other) >= 0;
        }
    }
}