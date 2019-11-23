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

            var list = flips.ToList();
            foreach (var coins in list)
            {
                var stringCoins = Convert.ToString(coins);
                Console.WriteLine(stringCoins);

                if (stringCoins == "Head")
                {
                    currentHead++;

                    currentTail = 0;
                }
                else
                {
                    currentTail++;
                    currentHead = 0;
                }
                if (currentTail > resultTail)
                    resultTail = currentTail;
                else if (currentHead > resultHead)
                    resultHead = currentHead;
            }
            if (resultHead > resultTail)
                return resultHead;
            else
                return resultTail;
        }
        public int resultHead { get; set; }
        public int resultTail { get; set; }
        public int currentHead { get; set; }
        public int currentTail { get; set; }
    }
}
