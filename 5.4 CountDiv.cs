using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int A, int B, int K) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        int offsetForLeftRange = 0;
        if ( A % K == 0) { ++offsetForLeftRange; }
        return  (B/K) - (A/K) + offsetForLeftRange;
    }
}
