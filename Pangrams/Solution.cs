using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Pangrams
    {
        static void Main(string[] args)
        {
            string ipt = Console.ReadLine().Trim().ToLower().Replace(" ", string.Empty);

            bool[] arr = new bool[26];

            foreach (char c in ipt)
            {
                int idx = (int)c - 97;
                arr[idx] = true;
            }

            bool p = true;
            foreach (bool e in arr)
            {
                if (!e)
                {
                    p = false;
                    break;
                }
            }

            if(p)
                Console.WriteLine("pangram");
            else
                Console.WriteLine("not pangram");
        }
    }
}
