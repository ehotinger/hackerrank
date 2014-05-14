using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Solution
    {
        private static readonly string KEY = "RDA";

        public static void Main(string[] args)
        {
            String input = Console.ReadLine().Trim();

            Console.WriteLine(Encrypt(input));
            Console.ReadLine();
        }

        public static string Encrypt(String input)
        {
            int ROWS = (int)Math.Floor(Math.Sqrt(input.Length));
            int COLUMNS = (int)Math.Ceiling(Math.Sqrt(input.Length));
            string output = "";

            // Since floor(sqrt(word)) <= width,
            // we need to increase width by one if the input's length
            // is greater than the total area than our grid.
            if (input.Length > ROWS * COLUMNS)
            {
                ROWS++;
            }

            String[,] wordGrid = new String[ROWS, COLUMNS];
            int index = 0;

            // Create the grid going left to right, top to bottom
            // and fill it out using each character of the string in each
            // block.
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    if (index < input.Length)
                        wordGrid[i, j] = input.Substring(index, 1);
                    index++;
                }
            }

            // Go through the grid column by column and print out the results of
            // the grid.
           for (int k = 0; k < COLUMNS; k++)
            {
                for (int l = 0; l < ROWS; l++)
                {
                    if (wordGrid[l, k] != null)
                        output += wordGrid[l, k];
                }
            output+=" ";
            }

            return output;
        }
    }
}
