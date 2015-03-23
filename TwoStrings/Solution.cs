using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class TwoStrings
    {
        public static void Main(String[] args)
        {
            int numCases = int.Parse(Console.ReadLine());

            while (numCases > 0)
            {
                numCases--;

                char[] A = Console.ReadLine().ToCharArray();
                char[] B = Console.ReadLine().ToCharArray();

                bool[] arr = new bool[26];

                foreach (char c in A)
                    arr[c - 'a'] = true;

                bool found = false;

                foreach (char c in B)
                    if (arr[c - 'a'])
                    {
                        found = true;
                        break;
                    }

                if(found)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }

        }
    }
}
