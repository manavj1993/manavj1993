using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice.HackerRankPractice
{
    //Link to the actual program: https://www.hackerrank.com/challenges/ctci-making-anagrams/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
    public static class MakingAnagrams
    {
        /*
     * Complete the 'makeAnagram' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING a
     *  2. STRING b
     */

        public static int MakeAnagram(string a, string b)
        {
            int output = 0;
            List<char> charList = a.Where(x => b.Contains(x)).Select(x => x).ToList();

            output += DeletedChars(a, charList);
            output += DeletedChars(b, charList);
            return output;
        }

        private static int DeletedChars(string str, List<char> charList)
        {
            int deletedCharsNumber = 0;
            string finalStr = new string(str.Where(x => charList.Contains(x)).ToArray());
            deletedCharsNumber = str.Length - finalStr.Length;
            return deletedCharsNumber;
        }

        public static void MainFunction()
        {
            string a = "fcrxzwscanmligyxyvym"; //Console.ReadLine();

            string b = "jxwtrhvujlmrpdoqbisbwhmgpmeoke"; //Console.ReadLine();

            int res = MakeAnagram(a, b);
        }
    }
}