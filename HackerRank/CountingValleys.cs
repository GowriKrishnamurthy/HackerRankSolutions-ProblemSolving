using System.Collections.Generic;
using System.IO;
using System;

public class CountingValleys
{
    public static int countingValleys(int steps, string path)
    { 
        int seaLevel=0, valley=0;
        for(int i=0;i<steps;i++)
        {
            if (path[i] == 'U')
                seaLevel++;
            else            
                seaLevel--;
            
            if(seaLevel ==0 && path[i]=='U')
               valley++;                        
        }
        return valley;
    }
}

/*
An avid hiker keeps meticulous records of their hikes. During the last hike that took exactly  'steps' steps, for every step it was noted if it was an uphill,
U , or a downhill,  D step. Hikes always start and end at sea level, and each step up or down represents a  1 unit change in altitude. We define the following terms:

A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level and ending with a step down to sea level.
A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step up to sea level.
Given the sequence of up and down steps during a hike, find and print the number of valleys walked through.

8
UDDDUDUU
Sample Output

1
Explanation

If we represent _ as sea level, a step up as /, and a step down as \, the hike can be drawn as:

_/\      _
   \    /
    \/\/
The hiker enters and leaves one valley.

*/