using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        bool[] B = new bool[A.Length + 1];
         int smallest = 1;
         
         for(int i = 0; i < A.Length; i++)
         {
             if(A[i] > 0 && A[i] < B.Length)
             {
                 B[A[i] - 1] = true;
             }
         }
         
         for(int i = 0; i < B.Length; i++)
         {
             if(!B[i])
             {
                 return i + 1;
             }
         }
        return smallest;
    }
}
