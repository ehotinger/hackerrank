using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(GetIpType(Console.ReadLine().Trim()));
            }
        }

        public static string GetIpType(string s)
        {

            // Here we check the Match instance.
            if (Regex.IsMatch(s, @"^([1-9]?\d|1\d\d|2[0-4]\d|25[0-5])\.([1-9]?\d|1\d\d|2[0-4]\d|25[0-5])\.([1-9]?\d|1\d\d|2[0-4]\d|25[0-5])\.([1-9]?\d|1\d\d|2[0-4]\d|25[0-5])$",
                RegexOptions.IgnoreCase))
            {
                return "IPv4";
            }
            else if (Regex.IsMatch(s, @"^(([0-9]|[a-f]){1,4}:){7}([0-9]|[a-f]){1,4}$", RegexOptions.IgnoreCase))
            {
                return "IPv6";
            }

            //2001:0db8:0000:0000:0000:ff00:0042:8329


            return "Neither";
        }
    }
}
