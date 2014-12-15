using System;
using System.Text.RegularExpressions;

namespace SayingHi
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string line = Console.ReadLine();

                if (Regex.IsMatch(line, @"^(?i)hi\s[^d]"))
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
