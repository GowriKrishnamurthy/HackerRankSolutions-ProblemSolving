using System.Collections.Generic;
using System.IO;
using System;
using System.Text;
using System.Linq;

public class RepeatedString
{
    // Complete the repeatedString function below.
    public static long repeatedString(string s, long n)
    {
        var aCount = s.Count(c => c == 'a');
        var sLen = s.Length; 

        var mul = n / sLen;
        var rem = n % sLen;
        return mul * aCount + s.Take((int)rem).Count(c => c == 'a');
    }
}

/*
Lilah has a string,s , of lowercase English letters that she repeated infinitely many times.

Given an integer,n , find and print the number of letter a's in the first  letters of Lilah's infinite string.

For example, if the string s='abcac' and n=10, the substring we consider is abcacabcac, the first  10 characters of her infinite string. There are  4 occurrences of a in the substring.

Function Description

Complete the repeatedString function in the editor below. It should return an integer representing the number of occurrences of a in the prefix of length  in the infinitely repeating string.

repeatedString has the following parameter(s):

s: a string to repeat
n: the number of characters to consider

Sample Input 0
aba
10
Sample Output 0
7

Sample Input 1
a
1000000000000
Sample Output 1
1000000000000
*/