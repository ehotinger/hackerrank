using System;

namespace HackerRank
{
    public class Alternating_Characters
    {
        public static void Main(string[] args)
        {
            int NumTestCases = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < NumTestCases; i++)
            {
                char[] Letters = Console.ReadLine().ToCharArray();
                int NumChanges = 0;

                if (Letters.Length == 1)
                {
                    Console.WriteLine(0);
                    continue;
                }
                    

                char c = Letters[0];

                for (int j = 1; j < Letters.Length; j++)
                {
                    if (Letters[j] == c)
                        NumChanges++;
                    else
                        c = Letters[j];
                }

                Console.WriteLine(NumChanges);
                
            }
        }
    }
}
