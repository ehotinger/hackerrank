using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectingTowns
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine().Trim());

            while (T > 0)
            {
                // No need for this, just here to make the input file match.
                // It could be used to allocate the size of line required, but since
                // we're splitting it anyways, there's really no use.
                int NumTowns = Int32.Parse(Console.ReadLine().Trim());

                string[] line = Console.ReadLine().Trim().Split(' ');

                long result = 0;

                for (int j = 0; j < line.Length; j++)
                {
                    if (result == 0)
                    {
                        result = Int64.Parse(line[j]);
                    }

                    else
                    {
                        result *= Int64.Parse(line[j]);
                        result = result % 1234567;
                    }
                }

                Console.WriteLine(result);
                --T;
            }
        }
    }
}
