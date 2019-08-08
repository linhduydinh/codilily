using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        double minAvg = (A[0] + A[1]) / 2;
            int minIndex = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                double avg = (A[i] + A[i + 1]) / 2.0;
                if (avg < minAvg)
                {
                    minAvg = avg;
                    minIndex = i;
                }
            }

            for (int i = 0; i < A.Length - 2; i++)
            {
                double avg = (A[i] + A[i + 1] + A[i + 2])/3.0;
                if (avg < minAvg)
                {
                    minAvg = avg;
                    minIndex = i;
                }
            }
            return minIndex;
    }
}
