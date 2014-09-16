using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    // https://www.hackerrank.com/contests/csback2school-practice/challenges/stockmax
    public class StockMaximize
    {
        public static void Main(String[] args)
        {
            // Each day, buy 1 share of WOT, sell any # of WOT, or do nothing.

            int T = Int32.Parse(Console.ReadLine()); // # testcases

            while (T > 0)
            {
                int N = Int32.Parse(Console.ReadLine());

                int[] Nums = new int[N];

                Nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                int Len = Nums.Length - 1;
                int MaxFuturePrice = 0;
                long Profit = 0;

                for (int i = Len; i >= 0; --i)
                {
                    MaxFuturePrice = Math.Max(MaxFuturePrice, Nums[i]);
                    Profit += MaxFuturePrice - Nums[i];
                }

                Console.WriteLine(Profit);

                --T;
            }
        }
    }
}
