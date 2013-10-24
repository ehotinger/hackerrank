using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryChildren
{
    class Solution
    {
        private static int[] mySet;

        static string AngryChildren(int k)
        {
            Array.Sort(mySet);

            int currentMin = 0;
            int currentMax = k - 1;
            int unfairness = Int32.MaxValue;
            int currentUnfairness = 0;

            while (currentMax < mySet.Length)
            {
                currentUnfairness = Math.Abs(mySet[currentMax] - mySet[currentMin]);

                if (currentUnfairness < unfairness)
                    unfairness = currentUnfairness;

                ++currentMax;
                ++currentMin;
            }

            return unfairness.ToString();
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            mySet = new int[n];
            int k = Convert.ToInt32(Console.ReadLine().Trim());

            while (n > 0)
            {
                n--;
                int item = Convert.ToInt32(Console.ReadLine());
                mySet[n] = item;

            }

            Console.WriteLine(AngryChildren(k));
        }
    }
}
