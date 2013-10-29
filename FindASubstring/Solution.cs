using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FindASubstring
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

                if (!String.IsNullOrWhiteSpace(word))
                {
                    for (int k = 0; k < Sentences.Length; k++)
                    {
                        numOccurrences += Regex.Matches(Sentences[k], ".+" + word + ".+").Count;
                    }
                }

                Console.WriteLine(numOccurrences);
            }
        }
    }
}
