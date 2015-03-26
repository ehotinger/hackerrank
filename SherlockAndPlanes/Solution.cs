using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class SherlockAndPlanes
    {
        public static void Main(string[] args)
        {
            int numTestCases = int.Parse(Console.ReadLine());

            while (numTestCases > 0)
            {
                string[] line1 = Console.ReadLine().Split(' ');
                string[] line2 = Console.ReadLine().Split(' ');
                string[] line3 = Console.ReadLine().Split(' ');
                string[] line4 = Console.ReadLine().Split(' ');

                if (AllSame(line1, line2, line3, line4))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }

        public static bool AllSame(string[] line1, string[] line2, string[] line3, string[] line4)
        {

            for (int i = 0; i < 3; i++)
            {
                if (line1[i] == line2[i] && line1[i] == line3[i] && line1[i] == line4[i])
                    return true;
            }

            return false;
        }
    }
}
