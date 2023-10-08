using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LinkedListPractice
{
    public class ArrayPractice
    {
        //Write a C# Sharp program that stores elements in an array and prints them
        //        Test Data:
        //Input 10 elements in the array:
        //element - 0 : 1
        //element - 1 : 1
        //element - 2 : 2
        //.......
        //Expected Output :
        //Elements in array are: 1 1 2 3 4 5 6 7 8 9
        public void AddAndPrintArray(int input)
        {
            int[] array = new int[input];
            for (int i = 0; i < input; i++)
            {
                array[i] = i;
            }
            Console.WriteLine(String.Join(',', array));
            Console.Read();
        }

        //Search key(index) elements in an array
        //Input: Enter size of an array => 8 [1,45,65,24,78,35,23,21]
        //Enter the element to search => 45
        //Output: 2
        public void SearchKeyElementInArray()
        {
            Console.Write("Enter total number of elements in an array => ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int output = -1;
            Console.Write($"Enter any random {n} numbers comma(') separated => ");
            array = Console.ReadLine().Trim().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); //Split by single space ' '
            Console.Write("Enter any number from above numbers => ");
            int numberToFind = Convert.ToInt32(Console.ReadLine());
            if (array.Length != n)
            {
                Console.WriteLine($"Enter exactly {n} numbers");
                return;
            }
            for (int i = 0; i < n ; i++)
            {
                if (array[i] == numberToFind)
                {
                    output = i;
                    
                    return;
                }
            }
            Console.WriteLine($"The number {numberToFind} is at index position {output} of the array");
        }

        //Find minimum and 2nd minimum number of element in an array
        public void FindMinimumAnd2ndMinimumElementFromArray()
        {
            Console.Write("Enter array of elements comma seperated");
            int[] array = Console.ReadLine().Trim().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n1 = 0; //Lowest
            int n2 = 0; //2nd Lowest
            if (array.Length < 2)
            {
                Console.WriteLine("Please enter atleast 2 numbers");
                return;
            }
            if (array[0] < array[1])
            {
                n1 = array[0];
                n2 = array[1];
            }
            else
            {
                n2 = array[0];
                n1 = array[1];
            }
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i] < n1)
                {
                    n2 = n1;
                    n1 = array[i];
                }
                else if (array[i] < n2 && array[i] > n1)
                    n2 = array[i];
            }
            Console.WriteLine($"The lowest number is {n1} & 2nd lowest is {n2}");
        }

        public void FindMinAndMaxNumberFromArray()
        {
            Console.Write("Enter array of elements comma seperated");
            int[] array = Console.ReadLine().Trim().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int min = 0; 
            int max = 0; 
            if (array.Length < 2)
            {
                Console.WriteLine("Please enter atleast 2 numbers");
                return;
            }
            if (array[0] < array[1])
            {
                min = array[0];
                max = array[1];
            }
            else
            {
                max = array[0];
                min = array[1];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                else if (array[i] < min)
                    min = array[i];
            }

            Console.WriteLine($"The lowest number is {min} & highest is {max}");
        }

        public void Find2ndLargestAndMinimumNumber()
        {
            Console.Write("Enter array of elements comma seperated");
            int[] array = Console.ReadLine().Trim().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int min = 0;
            int max = 0;
            int secondMax = 0;
            
            if (array.Length < 2)
            {
                Console.WriteLine("Please enter atleast 2 numbers");
                return;
            }
            if (array[0] < array[1])
            {
                min = array[0];
                max = array[1];
            }
            else
            {
                max = array[0];
                min = array[1];
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
                else if (array[i] > max)
                {
                    secondMax = max;
                    max = array[i];
                }
            }
            Console.WriteLine($"The lowest number is {min} & 2nd highest is {secondMax}");
        }

        //Write a program to count the total times an element is repeated in an array
        //Input: Enter size of an array => 8 [1,1,1,3,3,4,5,2]
        //Output: 1 is occuring 3 times, 2 is occuring one time, 3 is occuring two times, 4 and 5 are occuring once
        public void CountFrequenciesOfElementsInArray()
        {
            Console.Write($"Enter any random numbers split by comma(,) => ");
            int[] array = Console.ReadLine().Trim().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); //Split by single space ' '
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (dict.ContainsKey(array[i]))
                    dict[array[i]]++;
                else
                    dict[array[i]] = 1;
            }
            Console.WriteLine($"{string.Join(',', dict.Select(x => $"The number {x.Key} was present {x.Value} times"))}");
        }

        //Delete an element from array
        public void DeleteElementFromArrayAndSort()
        {
            Console.Write("Enter array of elements comma seperated");
            int[] array = Console.ReadLine().Trim().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.Write("Enter any number to remove from above numbers => ");
            int numberToRemove = Convert.ToInt32(Console.ReadLine());
            int index = 0;
            for (int i = 0; i < numberToRemove; i++)
            {
                if (array[i] == numberToRemove)
                {
                    index = i;
                    break;
                }
            }
            array = array.Where((val, idx) => idx  != index).ToArray();
            array = array.OrderBy(x => x).ToArray();
            //List<int> indexes = new List<int>() { 0, 1, 2 };
            //array = array.Where((val, idx) => !indexes.Contains(idx)).ToArray(); //To Remove multiple indexes at once 
            Console.WriteLine(String.Join(",", array));
        }

        /* Write a program in C# which prints the number written in money words.
        Case 1: 12345 should be printed as twelve thousand three hundred five
        Case 2: 10000 should be printed as ten thousand
        Case 3: 1234567 should be printed as twelve lakhs thirty four thousand five hundred sixty seven */

        private static string[] ones = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                               "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

        private static string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        private static string[] thousands = { "", "Thousand", "Lakh", "Crore" };

        public static void PrintNumberToSentence()
        {
            int number = 1234567;
            string output = NumToWords(number);
            Console.WriteLine(output);
        }

        private static string NumToWords(int number)
        {
            string sentence = "";
            for (int i = 0; number > 0; i++)
            {
                if (number % 1000 != 0)
                {
                    sentence = ConvertToWords(number % 1000) + " " + thousands[i] + " " + sentence;
                }
                number /= 1000;
            }
            return sentence;
        }

        private static string ConvertToWords(int number)
        {
            if (number < 20)
                return ones[number];

            else if (number < 100)
                return tens[number / 10] + " " + (number % 10 > 0 ? " " + ones[number % 10] : " ");

            else
                return ones[number / 100] + " hundred " + (number % 100 > 0 ? ConvertToWords(number % 100) : "");
        }

        /*In a telephone keypad, each digit corresponds to a set of letters.
         * For example, the digit 2 corresponds to the letters "ABC," the digit 3 corresponds to "DEF," and so on.
         * Write a program that takes a string of digits as input and generates all possible 
         * letter combinations that can be formed using the keypad.
         * For instance, given the input "23," the program should output
         * ["AD", "AE", "AF", "BD", "BE", "BF", "CD", "CE", "CF"]. */

        private static Dictionary<char, string> keypad = new Dictionary<char, string>
        {
            {'2', "ABC"}, {'3', "DEF"}, {'4', "GHI"}, {'5', "JKL"},
            {'6', "MNO"}, {'7', "PQRS"}, {'8', "TUV"}, {'9', "WXYZ"}
        };

        public static void GenerateLetterCombinations()
        {
            string input = "234";
            List<string> combinations = new List<string>();

            GenerateCombinationsRecursive(input, 0, "", combinations);

            foreach (string combination in combinations)
            {
                Console.WriteLine(combination);
            }
        }

        private static void GenerateCombinationsRecursive(string input, int index, string current, List<string> result)
        {
            if (index == input.Length)
            {
                result.Add(current);
                return;
            }

            char digit = input[index];
            string letters = keypad[digit];

            foreach (char letter in letters)
            {
                GenerateCombinationsRecursive(input, index + 1, current + letter, result);
            }
        }

        /* Write a program that takes a Roman numeral as input and converts it to an integer.
        Roman numerals are represented by a combination of letters:
        "I" for 1, "V" for 5, "X" for 10, "L" for 50, "C" for 100, "D" for 500, and "M" for 1000.
        For example, the Roman numeral "IX" is 9 (10 - 1), "LVIII" is 58 (50 + 5 + 3),
        and "MCMXCIV" is 1994 (1000 + 900 + 90 + 4). */
        //private static Dictionary<char, int> dict = new Dictionary<char, int>();
        static Dictionary<char, int> romanValues = new Dictionary<char, int>
        {{'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
        {'C', 100}, {'D', 500}, {'M', 1000}};

        public static void RomanToNumeralConversion()
        {
            string romanNumeral = "MCMXCIV"; // Example Roman numeral -> 1994 is numeral for MCMXCIV
            int integerValue = RomanToInt(romanNumeral);
            Console.WriteLine("Roman numeral: " + romanNumeral + " and its Integer value: " + integerValue);
        }

        static int RomanToInt(string s)
        {
            int total = 0;
            int prevValue = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                int currentValue = romanValues[s[i]];

                if (currentValue >= prevValue)
                    total += currentValue;
                else
                    total -= currentValue;

                prevValue = currentValue;
            }

            return total;
        }

        //Write Program to find nth max and nth min from any array(rotated sorted or just sorted)
        public static void FindNthMaxMinFunction()
        {
            int[] rotatedArray = { 134, 178, 13, 24, 34, 56, 57, 68, 78, 89, 90, 112 };
            //Sorted array = { 13, 24, 34, 56, 57, 68, 78, 89, 90, 112, 134, 178 };
            int n = 4; 

            int nthMax = FindNthMax(rotatedArray, n); // 56
            int nthMin = FindNthMin(rotatedArray, n); // 90
            Console.WriteLine($"{n}th Max is {nthMax} & {n}th Min is {nthMin}");
        }

        private class MaxHeapComparer : IComparer<int>
        {
            public int Compare(int a, int b)
            {
                return b.CompareTo(a);
            }
        }

        private class MinHeapComparer : IComparer<int>
        {
            public int Compare(int a, int b)
            {
                return a.CompareTo(b);
            }
        }

        private static int FindNthMax(int[] arr, int n)
        {
            if (n < 0 && arr.Length == 0)
                throw new ArgumentException("Incorrect input");

            var maxHeap = new PriorityQueue<int, int>(new MaxHeapComparer());
            foreach (int a in arr)
            {
                maxHeap.Enqueue(a, a);
                if (maxHeap.Count > n)
                        maxHeap.Dequeue();
            }
            return maxHeap.Peek();
        }

        private static int FindNthMin(int[] arr, int n)
        {
            if (n < 0 && arr.Length == 0)
                throw new ArgumentException("Incorrect input");

            var minHeap = new PriorityQueue<int, int>(new MinHeapComparer());
            foreach (int a in arr)
            {
                minHeap.Enqueue(a, a);
                if (minHeap.Count > n)
                    minHeap.Dequeue();
            }
            return minHeap.Peek();
        }
    }
}