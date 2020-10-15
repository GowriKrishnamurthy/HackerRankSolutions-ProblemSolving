using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HackerRank
{
    class PlusMinusRatio
    {
        public static void plusMinus(int[] arr)
        {
            var n = arr.Count();
            decimal positives = arr.Count(x => x > 0);
            decimal negatives = arr.Count(x => x < 0);
            decimal zeroes = arr.Count(x => x == 0);

            Console.WriteLine(( positives / n).ToString("F6"));
            Console.WriteLine((negatives / n).ToString("F6"));
            Console.WriteLine((zeroes / n).ToString("F6"));
        }
    }
}

/*
 * Complete the plusMinus function in the editor below.

plusMinus has the following parameter(s):

int arr[n]: an array of integers
Print
Print the ratios of positive, negative and zero values in the array. 
Each value should be printed on a separate line with  6 digits after the decimal. 
The function should not return a value.

Print the following  3 lines, each to  6 decimals:

proportion of positive values
proportion of negative values
proportion of zeros
Sample Input

6
-4 3 -9 0 4 1         
Sample Output

0.500000
0.333333
0.166667
 * */