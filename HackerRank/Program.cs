using HackerRank.Solution;
using System;
using System.Collections.Generic;

namespace HackerRank
{
    class Program
    {
       static void Main(string[] args)
        {


            // Decrypt password
            Console.WriteLine(DecryptPassword.decryptPassword("pTo*Ta*O")); //poTaTO
            Console.WriteLine(DecryptPassword.decryptPassword("1Bl*Kg*u0")); //lBgKu1
            Console.WriteLine(DecryptPassword.decryptPassword("51Pa*0Lp*0e")); //aP1pL5e

            //Hourglass sum
            int[][] arr = new int[6][];
            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            Console.WriteLine(HourglassSum.hourglassSum(arr));
        }
    }
}
