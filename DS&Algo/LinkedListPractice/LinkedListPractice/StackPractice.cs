using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    public static class StackPractice
    {
        /*Write a program which checks if the given braces are opened and closed in correct order
        E.g. {{}} -> Correct order, {{[()]}} --> Correct order, {[}] --> Incorrect order*/
        public static void OpeningClosingOfBraces()
        {
            string input = "{{[]}}";
            Stack<char> stack = new Stack<char>();
            foreach (char i in input)
            {
                if (i == '{' || i == '[' || i == '(')
                    stack.Push(i);

                else
                {
                    var pop = stack.Pop();
                    if (i == ')' && pop != '(' || i == '}' && pop != '{' || i == ']' && pop != '[')
                    {
                        Console.WriteLine("The opening & closing braces are not in correct order");
                        return;
                    }
                }
            }
            Console.WriteLine("The opening & closing braces are in correct order");
        }

        /*This program checks if a given string is a palindrome (reads the same forwards and backwards) using a stack.
         E.g. 'madam', 'tenet', ''level */
        public static void CheckIfStringPalindrome()
        {
            string input = "lleevaeell";
            string result = "Input string is palindrome";
            bool isPopped = false;
            Stack<char> stack = new Stack<char>();
            if (input.Length == 2)
                result = input[0] != input[1] ? "Input string is not palindrome" : result;

            bool isEven = input.Length % 2 == 0;
            int middleCharIndexAt = (isEven ? input.Length / 2 : input.Length / 2 + 1) - 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (i <= middleCharIndexAt)
                {
                    stack.Push(input[i]);
                }
                else
                {
                    if (!isEven && !isPopped)
                    {
                        stack.Pop(); //In case of odd length, need to remove the last character since it will be only once
                        isPopped = true;
                    }

                    char pop = stack.Pop();
                    if (input[i] != pop)
                    {
                        result = "Input string is not palindrome";
                        break;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
