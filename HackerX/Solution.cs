using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerX
{

    // Incomplete Solution.
    public class Solution
    {
        // Constraints:
        // 1 <= N <= 100,000
        // 0 <= ti <= 100,000
        // 0 <= fi <= 100,000
        // t1 <= t2 <= ... <= tn
        // when changing a missile's initial frequency to fB you need |fB - fA| units of time.
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());

            // No missiles fired from enemy.
            if (N == 0)
            {
                Console.WriteLine("0");
            }

            else
            {
                Dictionary<int, HashSet<int>> EnemyMissiles = new Dictionary<int, HashSet<int>>(); ;

                BeginPreparations(N, EnemyMissiles);
                Console.WriteLine(GetNumMissilesRequired(EnemyMissiles));
            }
        }

        static void BeginPreparations(int N, Dictionary<int, HashSet<int>> EnemyMissiles)
        {
            // Time -> Frequency
            while (N > 0)
            {
                string[] missileInfo = Console.ReadLine().Split(' ');
                int MissileTime = Int32.Parse(missileInfo[0]);
                int MissileFrequency = Int32.Parse(missileInfo[1]);

                if (EnemyMissiles.ContainsKey(MissileTime))
                {
                    EnemyMissiles[MissileTime].Add(MissileFrequency);
                }

                else
                {
                    HashSet<int> MissileFrequencies = new HashSet<int>();
                    MissileFrequencies.Add(MissileFrequency);

                    EnemyMissiles.Add(MissileTime, MissileFrequencies);
                }

                N--;
            }
        }

        // Algorithm to compute the number of missiles required based on the time.
        static int GetNumMissilesRequired(Dictionary<int, HashSet<int>> EnemyMissiles)
        {
            List<HackerXMissile> HackerXMissiles = new List<HackerXMissile>();

            // Go through all the potential times that missiles strike at.
            foreach (int time in EnemyMissiles.Keys)
            {
                // And go through all of the potential frequencies at each time.
                foreach (int frequency in EnemyMissiles[time])
                {
                    // If our list of missiles is empty, we know that we have to add one
                    // to match the incoming time and frequency.
                    if (HackerXMissiles.Count == 0)
                    {
                        HackerXMissiles.Add(new HackerXMissile(time, frequency));
                    }

                    // Otherwise, we have to do a lot of checking.
                    else
                    {
                        IEnumerable<HackerXMissile> NotInUseMissiles = HackerXMissiles.Where(m => m.timeSlot != time);

                        // If there are no missiles that aren't in use, we are forced to add another to the list.
                        if (NotInUseMissiles.Count() == 0)
                        {
                            HackerXMissiles.Add(new HackerXMissile(time, frequency));
                        }

                        // Otherwise we need to see if any missiles could potentially scale in time to the required frequency.
                        // If no missiles can scale in time, then we'll be forced to add another to the list.
                        else
                        {
                            // Not In Use Missiles Where Min(|m. currentFrequency - frequency|)

                            // Note that the nearest frequency missile is not necessarily the correct missile to choose from...
                            // because it may have been used last turn but have a difference of 2 - in which case it isn't possible to use it.
                            // and rather than just skipping to the else and adding a new missile, we have to check the other missiles that have
                            // a greater distance and determine which (if any) should take the time to start ramping up to the correct frequency.
                            HackerXMissile nearestFrequencyMissile = NotInUseMissiles.OrderBy(m => Math.Abs(m.currentFrequency - frequency)).Take(1).First();

                            if ((time - nearestFrequencyMissile.timeSlot) >= (frequency - nearestFrequencyMissile.currentFrequency))
                            {
                                nearestFrequencyMissile.timeSlot = time;
                                nearestFrequencyMissile.currentFrequency = frequency;
                            }
                            else
                            {
                                HackerXMissiles.Add(new HackerXMissile(time, frequency));
                            }

                        }
                    }
                }
            }

            return HackerXMissiles.Count;
        }

    }

    public class HackerXMissile
    {
        public int timeSlot;
        public int currentFrequency;

        public HackerXMissile()
        {
            this.timeSlot = 0;
            this.currentFrequency = 0;
        }

        public HackerXMissile(int timeSlot, int currentFrequency)
        {
            this.timeSlot = timeSlot;
            this.currentFrequency = currentFrequency;
        }
    }

}
