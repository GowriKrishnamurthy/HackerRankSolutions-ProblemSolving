using System;

namespace HackerRank.Solution
{
    public class HalloweenSale
    {
        public static int howManyGames(int p, int d, int m, int s)
        {
            int count = 0;

            // Return the number of games you can buy
            while  (s >= p)
            {
                count++;
                s = s - p;
                p = Math.Max(p - d, m); 
            }                
            
            return count;
        }
    }
  }

/*
 * You wish to buy video games from the famous online video game store Mist.
Usually, all games are sold at the same price, p dollars. 
However, they are planning to have the seasonal Halloween Sale next month in which you can buy games at a cheaper price. 
Specifically, the first game you buy during the sale will be sold at p dollars, but every subsequent game you buy will be sold at exactly d dollars less than the cost of the previous one you bought. 
This will continue until the cost becomes less than or equal to m dollars, after which every game you buy will cost m dollars each.

For example, if ,  and , then the following are the costs of the first  games you buy, in order:

Sample Input 1
20 3 6 85

Sample Output 1
7


Sample Input 1
20 3 6 80

Sample Output 1
6
 */
