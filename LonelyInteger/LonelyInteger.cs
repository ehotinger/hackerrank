using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    // https://www.hackerrank.com/contests/csback2school-practice/challenges/lonely-integer 
    public class LonelyInteger
    {
        public static void Main(string[] args)
        {
            // # of Ints
            int N = Int32.Parse(Console.ReadLine());

            int[] Numbers = new int[N];

            Numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int lonely = Numbers[0];

            for (int i = 1; i < Numbers.Length; i++)
            {
                lonely ^= Numbers[i];
            }

            Console.WriteLine(lonely);
        }
    }
}
