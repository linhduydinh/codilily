using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int N, int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        int[] B = new int[N];
        int currentMax = 0;
        int currentMaxApplied = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] <= N)
            {
                if (B[A[i] - 1] < currentMaxApplied)
                {
                    B[A[i] - 1] = currentMaxApplied + 1;
                }
                else
                {
                    B[A[i] - 1]++;
                }
                currentMax = Math.Max(B[A[i] - 1], currentMax);
            }
            else
            {
                currentMaxApplied = currentMax;
            }
        }
        for (int i = 0; i < B.Length; i++)
        {
            if (B[i] < currentMaxApplied)
            {
                B[i] = currentMaxApplied;
            }
        }
        
        return B;
    }
}
