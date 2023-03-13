using SimpleGenericLinkedListPractice;
using DoubleLinkedListPractice;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    class Program
    {
        class MyClassA
        {
            public MyClassA()
            {
                Console.WriteLine("constructor A");
            }

            public void abc()
            {
                Console.WriteLine("A");
            }
        }

        class MyClassB : MyClassA
        {
            public MyClassB()
            {
                Console.WriteLine("constructor B");
            }

            public void abc()
            {
                Console.WriteLine("B");
            }
        }

        static void Main(string[] args)
        {
            //MyClassA a = new MyClassB();
            //MyClassA a = b;
            //a.abc();


            Logic logic = new Logic();
            logic.ReverseString("Manav");
            //logic.FindAllPrimeNumbersUptoGivenNumber();
            //logic.GetArmstrongNumbers(1, 372);
            //logic.FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12);

            //DoubleLinkedList 
            //{
            //    DoubleLinkedList db = new DoubleLinkedList();
            //    db.Add(1);
            //    db.Add(2);
            //    db.Add(3);
            //    db.Add(4);
            //    db.Add(5);
            //    db.Add(6);
            //    db.GetAll();
            //    int remove = 3;
            //    Console.WriteLine("Below is get all after removing a node value: " + remove.ToString());
            //    db.Remove(remove);
            //    db.GetAll();
            //    Console.Read();
            //}

            //What will be the output for this?
            //{
            //    int[] arr = new int[2];
            //    arr[1] = 10;
            //    object o = arr;
            //    int[] arr1 = (int[])o;
            //    arr1[1] = 100;
            //    Console.WriteLine(arr[1]);
            //    ((int[])o)[1] = 1000;
            //    Console.WriteLine(arr[1]);
            //}

            //Logic for print 1 to 100 without using loop
            //{
            //    Console.WriteLine(String.Join(",", Array.ConvertAll<int, string>(Enumerable.Range(1, 100).ToArray(), i => i.ToString())));
            //    Console.Read();
            //}

            //Logic to print 1 to 100 without using numbers
            //{
            //    int one = 'x' / 'x';
            //    string s = "----------";

            //    for (int i = one; i <= s.Length * s.Length; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Reverse a string in c#
            //{
            //    string str = "HelloWorld";
            //    char[] charArray = str.ToArray();
            //    char[] reverse = new char[str.Length];
            //    for (int i = 0, j = charArray.Length - 1; i < j; i++, j--)
            //    {
            //        reverse[i] = charArray[j];
            //        reverse[j] = charArray[i];
            //    }
            //    string reverseString = new string(reverse);
            //    Console.WriteLine(reverseString);
            //    Console.Read();
            //}

            //SimpleLinkedList with tail
            //{
            //SimpleLinkedListTail sll = new SimpleLinkedListTail();
            //sll.AddLast(1);
            //sll.AddLast(2);
            //sll.AddLast(3);
            //sll.AddLast(4);
            //sll.AddFirst("first");
            //sll.AddLast("last");
            //sll.ReadAll();
            //}

            //SimpleLinkedList with tail and generics
            //{
            //SimpleLinkedListTail<int> sll = new SimpleLinkedListTail<int>();
            //sll.AddLast(1);
            //sll.AddLast(2);
            //sll.AddLast(3);
            //sll.AddLast(4);
            //sll.AddFirst(0);
            //sll.AddLast(5);
            //sll.Remove(4);
            //sll.ReadAll();
            //}
        }
    }
}