using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateFeast
{
    class Solution
    {
        // 2 <= N <= 100000
        // 1 <= C <= N
        // 2 <= M <= N
        // Goes to store with $N bill with $C being the price of each chocolate.
        // For every M wrappers he gives the store, he'll get one chocolate for free.
        static string NumberChocolates(int n, int c, int m)
        {
            int totalChocolates = 0;

            int baseNumChocolates = n / c;
            totalChocolates += baseNumChocolates;

            int additionalChocolates = baseNumChocolates / m; // From wrappers.
            totalChocolates += additionalChocolates;

            int remainingWrappers = baseNumChocolates % m;
            int totalWrappers = remainingWrappers + additionalChocolates;

            while (totalWrappers >= m)
            {
                baseNumChocolates = totalWrappers / m;
                remainingWrappers = totalWrappers % m;
                totalChocolates += baseNumChocolates;
                totalWrappers = remainingWrappers + baseNumChocolates;
            }

            return totalChocolates.ToString();
        }

        static void Main(string[] args)
        {
            int numTestCases = Convert.ToInt32(Console.ReadLine().Trim());

            while (numTestCases > 0)
            {
                string testCase = Console.ReadLine().Trim();
                string[] testCaseValues = testCase.Split(' ');

                int n = Convert.ToInt32(testCaseValues[0]);
                int c = Convert.ToInt32(testCaseValues[1]);
                int m = Convert.ToInt32(testCaseValues[2]);

                string numChocolates = NumberChocolates(n, c, m);
                Console.WriteLine(numChocolates);

                numTestCases--;
            }
            Console.ReadLine();
        }
    }
}
