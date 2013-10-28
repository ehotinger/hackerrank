using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UK_And_US
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine().Trim());
            string[] Lines = new string[N];

            for (int i = 0; i < N; i++)
            {
                Lines[i] = Console.ReadLine().Trim();
            }

            int T = Int32.Parse(Console.ReadLine().Trim());

            for (int j = 0; j < T; j++)
            {
                string SearchTerm = Console.ReadLine().Trim();

                // Remove the -ze from all SearchTerms so we can Regex on (z|s)e
                Console.WriteLine(GetNumOccurrences(Lines, SearchTerm.Substring(0, SearchTerm.Length - 2)));
            }
        }

        public static int GetNumOccurrences(string[] Lines, string SearchTerm)
        {
            int NumOccurrences = 0;
            string regex = "(" + SearchTerm + "(s|z)e)";

            foreach (string Line in Lines)
            {
                NumOccurrences += Regex.Matches(Line, regex).Count;
            }

            return NumOccurrences;
        }
    }
}
