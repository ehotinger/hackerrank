using System;
using System.Collections.Generic;

namespace ClosestNumbers
{
    class Solution
    {
        static string ClosestNumbers(int[] a)
        {
            // The minimum difference will be one of the differences from the consecutive pairs in sorted order.
            Array.Sort(a);

            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

            int minDiff = a[1] - a[0];
            List<int> newList = new List<int>();
            newList.Add(a[0]);

            dict.Add(minDiff, newList);
            dict[minDiff].Add(a[1]);

            for (int i = 2; i < a.Length; i++)
            {
                int numberDifference = a[i] - a[i - 1];
                minDiff = Math.Min(minDiff, numberDifference);

                if (dict.ContainsKey(numberDifference))
                {
                    dict[numberDifference].Add(a[i - 1]);
                    dict[numberDifference].Add(a[i]);
                }
                else
                {
                    newList = new List<int>();
                    newList.Add(a[i - 1]);

                    dict.Add(numberDifference, newList);
                    dict[numberDifference].Add(a[i]);
                }
            }

            return string.Join(" ", dict[minDiff]);
        }

        static void Main(String[] args)
        {
            string smallestDiffPairs;
            int _a_size = Convert.ToInt32(Console.ReadLine().Trim());
            int[] _a = new int[_a_size];
            int _a_item;

            String move = Console.ReadLine().Trim();
            String[] move_split = move.Split(' ');

            for (int i = 0; i < move_split.Length; i++)
            {
                _a_item = Convert.ToInt32(move_split[i]);
                _a[i] = _a_item;
            }

            smallestDiffPairs = ClosestNumbers(_a);
            Console.WriteLine(smallestDiffPairs);
        }
    }
}
