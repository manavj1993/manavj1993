using LinkedListPractice.Algorithms;
using LinkedListPractice.BinarySearchTree;
using LinkedListPractice.RoughProblemSolving;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using LinkedListPractice.GeeksForGeeksPractice;
using LinkedListPractice.LinkedList;
using LinkedListPractice.HackerRankPractice;

namespace LinkedListPractice
{
    class Program
    {
        //public class classA
        //{
        //    public virtual string Print()
        //    {
        //        return "classA";
        //    }
        //}

        //public class classB : classA
        //{
        //    public new string Print()
        //    {
        //        return "classB";
        //    }
        //}

        //public class classC : classB
        //{
        //    public new string Print()
        //    {
        //        return "ClassC";
        //    }
        //}

        static void Main(string[] args)
        {
            //classA a = new classB();
            //Console.WriteLine(a.Print());
            //ObserverClientClass.Function();

            //Logic logic = new Logic();

            //logic.ReverseString("Manav");
            //logic.FindAllPrimeNumbersUptoGivenNumber();
            //logic.GetArmstrongNumbers(1, 10000);
            //logic.FibbonacciSeries("key1");

            //ArrayPractice arrayPractice = new ArrayPractice();
            //ArrayPractice.PrintNumberToSentence();
            //ArrayPractice.FindNthMaxMinFunction();
            //ArrayPractice.GenerateLetterCombinations();
            //ArrayPractice.RomanToNumeralConversion();
            //arrayPractice.SearchKeyElementInArray();
            //arrayPractice.AddAndPrintArray(10);
            //arrayPractice.FindMinimumAnd2ndMinimumElementFromArray();
            //arrayPractice.FindMinAndMaxNumberFromArray();
            //arrayPractice.Find2ndLargestAndMinimumNumber();
            //arrayPractice.CountFrequenciesOfElementsInArray();
            //arrayPractice.DeleteElementFromArrayAndSort();
            //arrayPractice.IncrementalCheck();
            //logic.FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12);

            //StackPractice.CheckIfStringPalindrome();
            //BankOCR.MainFunction();
            //MultiDelegateExample mde = new MultiDelegateExample();
            //ArithOp arithOp = new ArithOp(mde.Subtract);
            //arithOp += new ArithOp(mde.Add);
            //arithOp(12, 4);
            //arithOp -= new ArithOp(mde.Subtract);
            //arithOp -= new ArithOp(mde.Subtract);
            //arithOp(10, 4);
            //arithOp -= new ArithOp(mde.Subtract);
            //arithOp -= new ArithOp(mde.Subtract);
            //arithOp -= new ArithOp(mde.Subtract);
            //arithOp(10, 4);
            //arithOp += new ArithOp(mde.Add);
            //arithOp(10, 4);
            //arithOp -= new ArithOp(mde.Add);
            //arithOp -= new ArithOp(mde.Add);
            //arithOp(10, 4);

            //Binary Tree
            //BinaryTree<int> bst = new BinaryTree<int>();
            //bst.Add(15);
            //bst.Add(7);
            //bst.Add(8);
            //bst.Add(10);
            //bst.Add(16);
            //bst.Add(19);
            //bst.Add(20);
            //bst.DisplayTree();


            //Iterative Sorting
            //SortingPractice.IterativeMethodSorting();
            //SortingAlgorithms.BubbleSort();
            //SortingAlgorithms.QuickSort();
            //SortingAlgorithms.QuickSortString();
            //SortingAlgorithms.MergeSortMain();
            //DoubleLinkedList .
            //{
            //DoubleLinkedList db = new DoubleLinkedList();
            //db.Add(1);
            //db.Add(2);
            //db.Add(3);
            //db.GetAll();
            //db.GetAllReverse();
            //    int remove = 3;
            //    Console.WriteLine("Below is get all after removing a node value: " + remove.ToString());
            //    db.Remove(remove);
            //    db.GetAll();
            //    Console.Read();
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

            //Geeks For Geeks Practice
            //GeeksForGeeks.LongestCommonSubsequence(6, 6, "ABCDGH", "AEDFHR");
            //GeeksForGeeks.HasThreeIntegersWithSum();

            //SearchingAlgorithmsPractice.MainFunction();
            //LinqPractice.MainFunction();

            MakingAnagrams.MainFunction();
        }
    }
}