using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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
            int flag = 0;
            int output = 0;
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
                    Console.WriteLine($"The number {numberToFind} is at position {output + 1} of the array");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine($"Number {numberToFind} not found in the array");
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

        public static int i = 0;
        public void PracticeOnly()
        {
            (i++).Assign();
        }
    }
    static class Extensionss
    {
        public static void Assign(this int i)
        {
            Console.WriteLine(ArrayPractice.i);
            Console.WriteLine(i);
        }
    }


}