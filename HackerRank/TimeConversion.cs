using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HackerRank
{
    public class TimeConversion
    {
        public static string timeConversion(string s)
        {
            /*
             * Write your code here.
             */
            DateTime timeValue = Convert.ToDateTime(s);
            return timeValue.ToString("HH:mm:ss");
        }
    }
}

/*
 Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.

Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

Sample Input 0
07:05:45PM

Sample Output 0
19:05:45

*/