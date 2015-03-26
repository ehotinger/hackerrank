using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class BdayGift
    {
        public static void Main(String[] args)
        {
            int num = int.Parse(Console.ReadLine());
            long tot = 0;

            for (int i = 0; i < num; i++)
                tot += long.Parse(Console.ReadLine());

            long val = tot / 2;
            string end = ".5";

            if (tot % 2 == 0)
                end = ".0";

            Console.WriteLine(val + end);
        }
    }
}