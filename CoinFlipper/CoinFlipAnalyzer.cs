using System.Collections.Generic;
using CoinFlipper.Models;
using CoinFlipper.Hardcore.Adapters;
using System.Linq;
using System;

namespace CoinFlipper
{
    public class CoinFlipAnalyzer
    {
        public int CountLongestStreak(IEnumerable<CoinFlipResult> flips)
        {
            //return HardcoreAdapter.CountLongestStreak(flips);
            //return new LongestStreakObfuscatedRecursiveStrategy().Count(flips);
            string current = null;
            int highest = 0;
            int count = 0;

            var list = flips.ToList();
            foreach (var coins in list)
            {
                string stringCoin = Convert.ToString(coins);
                if (stringCoin == current)
                {
                    count++;
                    if (count > highest)
                        highest = count;
                }
                else
                {
                    count = 1;
                    current = stringCoin;
                    if (list.Count == 0)
                        highest = 0;
                    if (list.Count == 1)
                        highest = 1;
                }
            }
            return highest;
                //    var stringCoins = Convert.ToString(coins);
                //    Console.WriteLine(stringCoins);

                //    if (stringCoins == "Head")
                //    {
                //        currentHead++;

                //        currentTail = 0;
                //    }
                //    else
                //    {
                //        currentTail++;
                //        currentHead = 0;
                //    }
                //    if (currentTail > resultTail)
                //        resultTail = currentTail;
                //    else if (currentHead > resultHead)
                //        resultHead = currentHead;
                //}
                //if (resultHead > resultTail)
                //    return resultHead;
                //else
                //    return resultTail;
            }
        //public int resultHead { get; set; }
        //public int resultTail { get; set; }
        //public int currentHead { get; set; }
        //public int currentTail { get; set; }
    }
}
