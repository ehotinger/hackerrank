using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        long[] s = new long[n];
        string[] s_temp = Console.ReadLine().Split(' ');
        s = Array.ConvertAll(s_temp, long.Parse);
        long maxPerimeter = -1;
        long[] side = new long[3]; //Storing the maximum perimeter triangle's sides' length
        long perimeter; //Storing the triangle's perimeter for each test
        //Because there are 3 sides, we iterate all of their combinations in 3 nested-loops
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    if ((i != k) && (i != j) && (j != k))
                    {
                        //A triangle is non-degenerate if:
                        //a + b > c
                        //a + c > b
                        //b + c > a
                        //Where a, b, and c are the triangle's sides' length respectively
                        if ((s[i] + s[j] > s[k]) && (s[i] + s[k] > s[j]) && (s[j] + s[k] > s[i]))
                        {
                            perimeter = s[i] + s[j] + s[k];
                            if (perimeter > maxPerimeter)
                            {
                                side = new long[] { s[i], s[j], s[k] };
                                maxPerimeter = perimeter;
                            }
                        }
                    }
                }
            }
        }
        if (maxPerimeter == -1)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Array.Sort(side);
            Console.WriteLine("{0} {1} {2}", side[0], side[1], side[2]);
        }
    }
}
