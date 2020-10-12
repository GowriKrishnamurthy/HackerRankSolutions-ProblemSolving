using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

public static class RotateLeft
{

    /*
     * Complete the 'rotateLeft' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER d
     *  2. INTEGER_ARRAY arr
     *  
     *  A left rotation operation on an array of size  shifts each of the array's elements  unit to the left. 
     *  Given an integer, , rotate the array that many steps left and return the result.
    Example

    After  rotations, .
    Function Description
    Complete the rotateLeft function in the editor below.
    rotateLeft has the following parameters:
    
    int d: the amount to rotate by
    int arr[n]: the array to rotate
    
    Returns
    int[n]: the rotated array
    
    Input Format
    The first line contains two space-separated integers that denote , the number of integers, and , the number of left rotations to perform.
    The second line contains  space-separated integers that describe .

    Sample Input
    5 4
    1 2 3 4 5
    
    Sample Output
    5 1 2 3 4
     */

    public static List<int> rotateLeft(int d, List<int> arr)
    {
        return arr.Skip(d).Concat(arr.Take(d)).ToList();
    }

    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d)
    {
        for (int j = 0; j < d; j++)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int tmp = a[i];
                a[i] = a[i + 1];
                a[i + 1] = tmp;
            }
        }
        return a;
    }
}
