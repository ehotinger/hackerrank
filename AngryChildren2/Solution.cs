using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryChildren2
{
    class Solution
    {
        private static int[] mySet;

        static string AngryChildren(int k)
        {
            Array.Sort(mySet);

            int currentMin = 0;
            int currentMax = k - 1;
            ulong unfairness = UInt64.MaxValue;
            ulong currentUnfairness = 0;
            int pointer;
            ulong temp = UInt64.MaxValue;

            while (currentMax < mySet.Length)
            {
                pointer = currentMin;

                // If first time running.
                if (temp == UInt64.MaxValue)
                {
                    // Iterate over the entire subset of the array.
                    while (pointer < currentMax)
                    {
                        // Start at the first point in the array and go to the end;
                        // calculate the current unfairness as the sum of all the permutations in between.
                        for (int i = pointer + 1; i <= currentMax; i++)
                        {
                            currentUnfairness += (ulong)(mySet[i] - mySet[pointer]);
                        }

                        // Set temp equal to the first run through of the subset.
                        if (pointer == currentMin)
                        {
                            temp = currentUnfairness;
                        }

                        ++pointer;
                    }
                }

                // If it's not the first time running...
                else
                {
                    // Start at the beginning of the subset and add the permutations
                    // from the last element in the subset.
                    for (int i = currentMin; i < currentMax; i++)
                    {
                        currentUnfairness += (ulong)(mySet[currentMax] - mySet[i]);
                    }

                    // Subtract the previous temp value (the starting permutations)
                    currentUnfairness -= temp;

                    // Reset the temp
                    temp = 0;

                    // Create the new temp value as the starting permutations of this subset
                    for (int j = pointer + 1; j <= currentMax; j++)
                    {
                        temp += (ulong)(mySet[j] - mySet[pointer]);
                    }
                }

                if (currentUnfairness < unfairness)
                    unfairness = currentUnfairness;

                ++currentMax;
                ++currentMin;
            }

            return unfairness.ToString();
        }

        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            mySet = new int[n];
            int k = Int32.Parse(Console.ReadLine());

            while (n > 0)
            {
                n--;
                mySet[n] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine(AngryChildren(k));
        }
    }
}
