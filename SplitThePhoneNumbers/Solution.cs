using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SplitThePhoneNumbers
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string s = Console.ReadLine().Trim();

                string regex = @"(\d{1,3})[-|\s](\d{1,3})[-|\s](\d{4,10})";
                GroupCollection t = Regex.Match(s, regex).Groups;

                if (t.Count == 4)
                {
                    Console.WriteLine("CountryCode=" + t[1] + ",LocalAreaCode=" + t[2] + ",Number=" + t[3]);
                }
            }
        }
    }
}
