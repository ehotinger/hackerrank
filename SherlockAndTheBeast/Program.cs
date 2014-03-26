using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockAndTheBeast
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int NumTests = Int32.Parse(Console.ReadLine().Trim());

            while (NumTests > 0)
            {
                String s = "";

                NumTests--;

                int N = Int32.Parse(Console.ReadLine().Trim());

                for (int i = N; i >= 0; i--)
                {
                    if (i % 3 == 0 && (N - i) % 5 == 0)
                    {
                        s = new String('5', i) + new String('3', N - i);

                        break;
                    }
                }

                if (s == String.Empty)
                    Console.WriteLine(-1);

                else
                    Console.WriteLine(s);
            }

        }
    }
}
