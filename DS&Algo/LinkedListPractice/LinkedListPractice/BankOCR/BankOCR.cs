using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LinkedListPractice
{
    public static class BankOCR
    {

        public static void MainFunction()
        {

            string[] entryLines = File.ReadAllLines("BankOCRDataFile.txt");

            for (int i = 0; i < entryLines.Length; i += 4)
            {
                if (i + 3 <= entryLines.Length)
                {
                    string line1 = entryLines[i];
                    string line2 = entryLines[i + 1];
                    string line3 = entryLines[i + 2];

                    // Call your parsing function with the 3 lines
                    string accountNumber = ParseLines(line1, line2, line3);
                }
            }
        }

        private static string ParseLines(string line1, string line2, string line3)
        {
            char[] line1CharArray = line1.ToCharArray();
            char[] line2CharArray = line2.ToCharArray();
            char[] line3CharArray = line3.ToCharArray();
            char[,,] array = CharArrr;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < line1CharArray.Length; i += 3)
            {
                for (int j = 0; j < line2CharArray.Length; j += 3)
                {
                    for (int k = 0; k < line3CharArray.Length; k += 3)
                    {
                        if (i + 2 <= line1CharArray.Length && j + 2 <= line2CharArray.Length && k + 2 <= line3CharArray.Length)
                        {
                            char[,] charArray = new char[,]
                                {
                                    { line1CharArray[i], line1CharArray[i+1], line1CharArray[i+2] },
                                    { line2CharArray[j], line2CharArray[j+1], line2CharArray[j+2] },
                                    { line3CharArray[k], line3CharArray[k+1], line3CharArray[k+2] },
                                };
                            dictMapping.TryGetValue(charArray, out int value);
                            sb.Append(Convert.ToString(value)); 
                        }
                    }
                }
            }
            return sb.ToString();
        }

        private static Dictionary<char[,], int> dictMapping = new Dictionary<char[,], int>
        {
            { new char[,]
                {
                    { ' ', ' ', ' ' },
                    { ' ', ' ', '|' },
                    { ' ', ' ', '|' }
                },1 
            },
            { new char[,]
                {
                    { ' ', '_', ' ' },
                    { ' ', '_', '|' },
                    { '|', '_', ' ' }
                }, 2 
            },
            { new char[,]
                {
                    { ' ', '_', ' ' },
                    { ' ', '_', '|' },
                    { ' ', '_', '|' }
                }, 3 
            },
            { new char[,]
                {
                    { ' ', ' ', ' ' },
                    { '|', '_', '|' },
                    { ' ', ' ', '|' }
                }, 4 
            },
            { new char[,]
                {
                    { ' ', '_', ' ' },
                    { '|', '_', ' ' },
                    { ' ', '_', '|' }
                }, 5 
            },
            { new char[,]
                {
                    { ' ', '_', ' ' },
                    { '|', '_', ' ' },
                    { '|', '_', '|' }
                }, 6 
            },
            { new char[,]
                {
                    { ' ', '_', ' ' },
                    { ' ', ' ', '|' },
                    { ' ', ' ', '|' }
                }, 7 
            },
            { new char[,]
                {
                    { ' ', '_', ' ' },
                    { '|', '_', '|' },
                    { '|', '_', '|' }
                }, 8 
            },
            { new char[,]
                {
                    { ' ', '_', ' ' },
                    { '|', '_', '|' },
                    { ' ', '_', '|' }
                }, 9 
            },
            { new char[,]
                {
                    { ' ', '_', ' ' },
                    { '|', ' ', '|' },
                    { '|', '_', '|' }
                }, 0 
            }
        };

        private static char[,,] CharArrr = new char[,,]
            {
                {
                    {' ' },
                    {'|' }
                }
            };
    }
}