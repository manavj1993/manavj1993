using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListPractice
{
    public class Logic
    {
        //The function should return the list of zero based indices whose any two elements equals the target sum.
        //If no such elements are present then the function should return null.
        //For eg List = new List<int>(){1,3,5,7,9}
        //Target sum = 12

        ///Correct Examples
        //1 and 4(3 + 9 = 12)
        //2 and 3(5 + 7 = 12)

        ///Incorrect Examples
        //3 and 4(7 + 9 = 16)

        public void FindTwoSum(List<int> list, int targetSum)
        {
            if (list == null || !list.Any())
                Console.WriteLine("Not element in the list");

            if (targetSum == 0)
                Console.WriteLine("target sum is 0");

            List<Tuple<int, int>> result = new List<Tuple<int, int>>();

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i; j < list.Count; j++)
                {
                    if (i != j)
                    {
                        if (list[i] + list[j] == targetSum)
                        {
                            result.Add(Tuple.Create(i, j));
                        }
                    }
                }
            }

            if (result.Count == 0)
                Console.Write("No such indices pair found whose sum equals the target");

            else {
                foreach (var tuple in result)
                {
                    Console.WriteLine(tuple.Item1 + " and " + tuple.Item2);
                }
            }
        }

        //Find the list of all armstrong numbers between defined range
        public void GetArmstrongNumbers(int min, int max)
        {
            if (min.CompareTo(max) > 0)
                Console.WriteLine("min is greater than max number. Please provide valid range");

            List<int> list = new List<int>();
            for (int i = min; i <= max; i++)
            {
                var numberToDigits = GetDigits(i);
                var sum = 0;
                numberToDigits.ForEach<int>(item =>
                {
                    sum += item*item*item;
                });
                if (sum.CompareTo(i) == 0)
                    list.Add(i);
            }
            Console.WriteLine("Following are armstrong numbers");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }

        private IEnumerable<int> GetDigits(int number)
        {
            Stack<int> stack = new Stack<int>();
            while (number != 0)
            {
                var digit = number % 10;
                number = number / 10;
                stack.Push(digit);
            }
            return stack;
        }

        //Find all prime numbers upto a given digit with time complexity O(n √n)
        public void FindAllPrimeNumbersUptoGivenNumber()
        {
            Console.WriteLine("PrimeNumbers");
            int number;
            List<int> primeNumbers = new List<int>();
            do
            {
                Console.Clear();
                Console.WriteLine("Write a digit to find a list of prime numbers upto the mentioned digit except 0 and 1");
                bool isNumber = int.TryParse(Console.ReadLine(), out number);
            }
            while (number == 0 || number == 1);
            bool isPrime = true;

            for (int i = 2; i <= number; i++)
            {
                isPrime = FindPrimeNumber(i);
                if (isPrime)
                    primeNumbers.Add(i);
            }

            Console.WriteLine(string.Join(",", primeNumbers));
            Console.Read();
        }

        private bool FindPrimeNumber(int number)
        {
            bool isPrime = true;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }

        //Reverse the string
        public void ReverseString(string c)
        {
            string reverseString = string.Empty;
            char[] strChars = c.ToCharArray();

            for (int i = strChars.Length - 1; i >= 0; i--)
            {
                reverseString += strChars[i];
            }
            Console.WriteLine(reverseString);
        }

        public void FibbonacciSeries(string key)
        {
            // LOGIC 1
            //if (LongRunningEvents.TryGetValue(key, out LongRunningEvent? longRunningEvent))
            //    longRunningEvent.IsDelivered = true;

            //int n1 = 0, n2 = 1, n3, number;
            //Console.Write("Enter the number of elements: ");
            //number = int.Parse(Console.ReadLine());
            //Console.Write(n1 + "," + n2 + ","); //printing 0 and 1    
            //for (int i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            //{
            //    n3 = n1 + n2;
            //    Console.Write(n3 + ",");
            //    n1 = n2;
            //    n2 = n3;
            //}
            //Console.Read();


            // LOGIC 2

            ////0 1 1 2 3 5 8 13
            //int current = 1; //1 2 
            ////int temp       //0 1
            //int last = 0;    //1 1
            //List<int> list = new List<int>(); //0 1 1 2
            //list.Add(last); 
            //list.Add(current);
            //for (int i = list.Count + 1; i <= number; i++)
            //{
            //    current = current + last;
            //    int temp = last;
            //    last = current - temp;
            //    list.Add(current);
            //}
            //return list;
        }

        public static int ReverseNumber(int number)
        {
            int reverse = 0;
            while (number != 0)
            {
                int remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number /= 10;
            }
            return reverse;
        }
    }
}
