using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        Array.Sort(A);

        int len = A.Length;

        int right = A[len-1]*A[len-2]*A[len-3];

        int left = A[0]*A[1]*A[len-1];

        return right > left ? right : left;
    }
}
