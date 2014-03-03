using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    // https://www.hackerrank.com/challenges/anagram
    public class Anagram
    {
        public static void Main(string[] args)
        {

            int T = Int32.Parse(Console.ReadLine().Trim());

            do
            {
                T--;

                Console.WriteLine(Solve(Console.ReadLine().Trim()));

            }
            while (T > 0);
        }


        public static int Solve(String word)
        {
            int[] count = new int[26];
            int length = word.Length;
            int sum = 0;
            int i = 0;

            for (i = 0; i < 26; i++)
                count[i] = 0;


            if (length % 2 == 1)
                return -1;

            else
            {
                for (i = 0; i < length / 2; i++)
                    count[word[i] - 'a']++;

                for (i = length / 2; i < length; i++)
                    count[word[i] - 'a']--;

                for (i = 0; i < 26; i++)
                {
                    sum = sum + mod(count[i]);
                }

                sum = sum / 2;
            }


            return sum;
        }

        public static int mod(int x)
        {
            if (x < 0)
                return (-1) * x;

            else
                return x;
        }
    }
}
