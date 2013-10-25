using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSimilarity
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                Console.WriteLine(FindStringSimilarity(Console.ReadLine().Trim()));
            }
        }

        public static int FindStringSimilarity(string s)
        {
            // A string with only one possible suffix will always have a similarity of 1.
            if (s.Length == 1)
                return 1;

            char[] suffix = s.ToCharArray();

            int length = suffix.Length;

            int totalSimilarity = length;

            for (int i = 1; i < length; i++)
            {
                int j = 0;

                for (; j < length - i; j++)
                {
                    if (suffix[j] != suffix[j + i])
                    {
                        break;
                    }
                }

                totalSimilarity += j;
            }

            return totalSimilarity;
        }
    }
}