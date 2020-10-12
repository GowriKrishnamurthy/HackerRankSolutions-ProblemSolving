using HackerRank.Solution;
using System;
using System.Collections.Generic;

namespace HackerRank
{
    class Program
    {
       static void Main(string[] args)
        {
            /*
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
            */
            //Array rotate left
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int n = 5; // Convert.ToInt32(firstMultipleInput[0]);
            int d = 4; // Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr1 = new List<int> { 1, 2, 3, 4, 5 };
            //Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = RotateLeft.rotateLeft(d, arr1);

            Console.WriteLine(String.Join(" ", result));

        }
    }
}
