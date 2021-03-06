﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class MinimumSwaps
    {
        public static int minimumSwaps(int[] arr)
        {
            int minSwaps = 0;
            
            //key:number, value:index of the number
            Dictionary<int, int> lastIndexOf = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                lastIndexOf[arr[i]] = i;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                // Check if the current element is at the wrong place.
                if (arr[i] != i + 1)
                {
                    int value = arr[i];
                    if (value != i + 1)
                    {
                        arr[lastIndexOf[i + 1]] = value;
                        lastIndexOf[value] = lastIndexOf[i + 1];
                        minSwaps++;
                    }
                }
            }
            return minSwaps;
        }
    }
}
/*
 * You are given an unordered array consisting of consecutive integers  [1, 2, 3, ..., n] without any duplicates.
 * You are allowed to swap any two elements. 
 * You need to find the minimum number of swaps required to sort the array in ascending order.
 * 
 * For example, given the array  arr=[7, 1, 3, 2, 4, 5, 6]  we perform the following steps:

i   arr                         swap (indices)
0   [7, 1, 3, 2, 4, 5, 6]   swap (0,3)
1   [2, 1, 3, 7, 4, 5, 6]   swap (0,1)
2   [1, 2, 3, 7, 4, 5, 6]   swap (3,4)
3   [1, 2, 3, 4, 7, 5, 6]   swap (4,5)
4   [1, 2, 3, 4, 5, 7, 6]   swap (5,6)
5   [1, 2, 3, 4, 5, 6, 7]

It took  5 swaps to sort the array.

Output Format

Return the minimum number of swaps to sort the given array.

Sample Input 0
4
4 3 1 2
Sample Output 0
3

Sample Input 1
5
2 3 4 1 5
Sample Output 1
3

Sample Input 2
7
1 3 5 2 4 6 7
Sample Output 2
3
*/