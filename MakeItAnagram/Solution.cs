using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class MakeItAnagram
    {
        public static void Main(string[] args)
        {
            char[] A = Console.ReadLine().ToCharArray();
            char[] B = Console.ReadLine().ToCharArray();

            int[] diffs = new int[26];

            foreach (char c in A)
                diffs[c - 'a']++;
            foreach (char c in B)
                diffs[c - 'a']--;

            int numChanges = 0;

            foreach (int diff in diffs)
                numChanges += Math.Abs(diff);

            Console.WriteLine(numChanges);
        }
    }
}
