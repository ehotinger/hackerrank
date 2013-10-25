using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FindHackerRank
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(FindHackerRank(Console.ReadLine().Trim()));
            }
        }

        public static int FindHackerRank(string s)
        {
            // Starts and ends with hackerrank
            if (Regex.IsMatch(s, @"^hackerrank$", RegexOptions.IgnoreCase))
            {
                return 0;
            }

            // Starts with hackerrank
            else if (Regex.IsMatch(s, @"^hackerrank", RegexOptions.IgnoreCase))
            {
                return 1;
            }


            // Ends with hackerrank
            else if (Regex.IsMatch(s, @"hackerrank$", RegexOptions.IgnoreCase))
            {
                return 2;
            }

            return -1;
        }
    }
}
