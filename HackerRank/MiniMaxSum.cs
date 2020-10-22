﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace HackerRank.Solution
{
    public class MiniMaxSum
    {
        public static void miniMaxSum(int[] arr)
        {
            List<long> newArr = Array.ConvertAll(arr, arrTemp => (long)arrTemp).ToList();

            long max = newArr.Max();
            long min = newArr.Min();

            long arrSum = newArr.Sum(x => x);
            Console.WriteLine((arrSum-max).ToString() + " " + (arrSum- min).ToString());
        }        
    }
}

/*
Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. 
Then print the respective minimum and maximum values as a single line of two space-separated long integers.
1 2 3 4 5
Sample Output

10 14

The numbers are 1,2, 3,4 , and 5. Calculate the following sums using four of the five integers:

Sum everything except 1 , the sum is 2+3+4+5 = 14
Sum everything except 2, the sum is 1+3+4+5 = 13
Sum everything except 3, the sum is 1+2+4+5 = 12
Sum everything except 4, the sum is 1+2+3+5 = 11
Sum everything except 5, the sum is 1+2+3+4 = 10
Hints: Beware of integer overflow! Use 64-bit Integer.
 
 */
