using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int N, K;
            string NK = Console.ReadLine();
            string[] NandK = NK.Split(new Char[] { ' ', '\t', '\n' });
            N = Convert.ToInt32(NandK[0]);
            K = Convert.ToInt32(NandK[1]);

            int[] flowers = new int[N];

            string numbers = Console.ReadLine();
            string[] split = numbers.Split(new Char[] { ' ', '\t', '\n' });

            int i = 0;

            foreach (string s in split)
            {
                if (s.Trim() != "")
                {
                    flowers[i++] = Convert.ToInt32(s);
                }
            }

            int result = 0;
            int NumFlowers = flowers.Length;

            int numFlowersBought = 0;
            int flowerTracker = 0;

            Array.Sort(flowers);

            for (int l = N - 1; l >= 0; l--)
            {
                result += flowers[l] * (numFlowersBought + 1);
                flowerTracker++;

                if (flowerTracker >= K)
                {
                    numFlowersBought++;
                    flowerTracker = 0;
                }
            }

            Console.WriteLine(result);
        }
    }
}
