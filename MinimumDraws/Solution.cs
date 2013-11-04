using System;

namespace MinimumDraws
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int NumTestCases = Int32.Parse(Console.ReadLine());

            while (NumTestCases > 0)
            {
                int NumSocks = Int32.Parse(Console.ReadLine());

                int MinDraws = NumSocks + 1;

                Console.WriteLine(MinDraws);

                --NumTestCases;
            }
        }
    }
}
