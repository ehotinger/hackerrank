using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenParty
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int NumTestCases = Int32.Parse(Console.ReadLine().Trim());

            while (NumTestCases > 0)
            {
                NumTestCases--;

                int K = Int32.Parse(Console.ReadLine().Trim());

                // If even... 
                if (K % 2 == 0)
                {
                    Console.WriteLine(Math.Pow(K / 2, 2));
                }
                else
                {
                    Console.WriteLine(Math.Ceiling((double)K / 2) * Math.Floor((double)K / 2));
                }
            }
            Console.ReadLine();
        }
    }
}
