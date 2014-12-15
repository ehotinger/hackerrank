using System;
using System.Text.RegularExpressions;

namespace UK_And_US_2
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());

            string words = "";

            for (int i = 0; i < N; i++)
            {
                words += " " + Console.ReadLine();
            }

            int T = Int32.Parse(Console.ReadLine());

            string[] Sentences = Regex.Split(words, @"\W");

            for (int j = 0; j < T; j++)
            {
                int numOccurrences = 0;

                string word = Console.ReadLine().Trim();
                word = word.Replace("our", @"o(u?)r");

                if (!String.IsNullOrWhiteSpace(word))
                {
                    for (int k = 0; k < Sentences.Length; k++)
                    {
                        numOccurrences += Regex.Matches(Sentences[k], "^" + word + "$").Count;
                    }
                }

                Console.WriteLine(numOccurrences);
            }
        }
    }
}

