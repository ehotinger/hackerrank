using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UtopianIdentificationNumber
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < N; i++)
            {
                string regex = @"^[a-z]{0,3}\d{2,8}[A-Z]{3,}$";

                if (Regex.IsMatch(Console.ReadLine().Trim(), regex))
                {
                    Console.WriteLine("VALID");
                }
                else
                {
                    Console.WriteLine("INVALID");
                }
            }
        }
    }
}
