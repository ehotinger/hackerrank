using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Solution
    {
        public static void Main(string[] args)
        {
            String input = Console.ReadLine().Trim();

            Console.WriteLine(Encrypt(input));
        }

        public static string Encrypt(String input)
        {
            int WIDTH = (int)Math.Floor(Math.Sqrt(input.Length));
            int HEIGHT = (int)Math.Ceiling(Math.Sqrt(input.Length));
            string output = "";

            // Since floor(sqrt(word)) <= width,
            // we need to increase width by one if the input's length
            // is greater than the total area than our grid.
            if (input.Length > WIDTH * HEIGHT)
            {
                WIDTH++;
            }

            String[,] wordGrid = new String[WIDTH, HEIGHT];
            int index = 0;

            // Create the grid going left to right, top to bottom
            // and fill it out using each character of the string in each
            // block.
            for (int i = 0; i < WIDTH; i++)
            {
                for (int j = 0; j < HEIGHT; j++)
                {
                    if (index < input.Length)
                        wordGrid[i, j] = input.Substring(index, 1);
                    index++;
                }
            }

            // Go through the grid column by column and print out the results of
            // the grid.
            for (int k = 0; k < HEIGHT; k++)
            {
                for (int l = 0; l < WIDTH; l++)
                {
                    if (wordGrid[l, k] != null)
                        output += wordGrid[l, k];
                }
                if (k != HEIGHT - 1)
                    output += " ";
            }

            return output;
        }
    }
}