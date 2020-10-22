using System;
using System.Collections.Generic;

namespace HackerRank.Solution
{
    public class DiagonalDifference
    {
        /* 
        * The function is expected to return an INTEGER.
        * The function accepts 2D_INTEGER_ARRAY arr as parameter.
        */
        public static int diagonalDifference(List<List<int>> arr)
        {
            int diagonal1Sum = 0, diagonal2Sum = 0;
            int n = arr.Count;
            for (int i=0; i<n; i++)
            {
                diagonal1Sum += arr[i][i];
                diagonal2Sum += arr[i][n-i-1];
            }
            return(Math.Abs(diagonal1Sum - diagonal2Sum));
        }        
    }
}

/*
 Given a square matrix, calculate the absolute difference between the sums of its diagonals.

Sample Input

3
11 2 4
4 5 6
10 8 -12
Sample Output

15
Explanation

The primary diagonal is:

11
   5
     -12
Sum across the primary diagonal: 11 + 5 - 12 = 4

The secondary diagonal is:

     4
   5
10
 */
