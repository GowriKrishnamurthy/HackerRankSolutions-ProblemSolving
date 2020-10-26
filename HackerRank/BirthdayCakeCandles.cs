using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace HackerRank.Solution
{
    public class BirthdayCakeCandles
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            int max = candles.Max();
            return candles.Count(a => a.Equals(max));
        }
    }
}

/*
You are in charge of the cake for a child's birthday. 
You have decided the cake will have one candle for each year of their total age. 
They will only be able to blow out the tallest of the candles. Count how many candles are tallest.

int candles[n]: the candle heights

Example
candles = [4,4,1,3]

The maximum height candles are 4 units high. There are  2 of them, so return 2.

Sample Input:
4
3 2 1 3

Sample Output :
2 
 */
