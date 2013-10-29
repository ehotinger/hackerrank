using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlienUsername
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string UserName = Console.ReadLine().Trim();

                if (Regex.IsMatch(UserName, @"^[_|\.][0-9]+[a-zA-Z]*_?$"))
                {
                    Console.WriteLine("VALID");
                }

                else
                {
                    Console.WriteLine("INVALID");
                }
            }
        }
    }
}
