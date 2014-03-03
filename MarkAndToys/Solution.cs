using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkAndToys
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            String[] line1 = Console.ReadLine().Trim().Split(' ');

            int N = Int32.Parse(line1[0]);
            int K = Int32.Parse(line1[1]);
            int count = 0;

            String[] line2 = Console.ReadLine().Trim().Split(' ');

            int[] ints = line2.Select(x => int.Parse(x)).ToArray();
            Array.Sort(ints);

            for (int i = 0; i < N; i++)
            {
                if (K - ints[i] >= 0)
                {
                    K -= ints[i];
                    count++;
                }

                else
                    break;
            }

            Console.WriteLine(count);
        }

    }
}
