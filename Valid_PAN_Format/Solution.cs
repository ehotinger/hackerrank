using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidPANFormat
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            //<char><char><char><char><char><digit><digit><digit><digit><char>
            //Each char is an uppercase letter. Each digit lies between 0 and 9
            int N = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                if (Regex.IsMatch(Console.ReadLine(), @"[A-Z]{5}[0-9]{4}[A-Z]"))
                {
                    Console.WriteLine("YES");
                }

                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
