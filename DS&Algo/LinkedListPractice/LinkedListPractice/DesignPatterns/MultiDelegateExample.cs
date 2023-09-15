using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice.RoughProblemSolving
{
    public delegate void ArithOp(int a, int b);
    internal class MultiDelegateExample
    {
        
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
}