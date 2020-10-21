using System;

namespace HackerRank.Solution
{
    public class Staircase
    {
        public static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('#', i + 1).PadLeft(n, ' '));
            }
        }        
    }
  }

/*
 Staircase detail

This is a staircase of size 4:

   #
  ##
 ###
####

Output Format

Print a staircase of size n using # symbols and spaces.

Note: The last line must have  spaces in it.

Sample Input

6 
Sample Output

     #
    ##
   ###
  ####
 #####
######
 */
