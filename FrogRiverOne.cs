using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int jumpCounter = X;
        bool[] positionArray = new bool[X + 1];
     
        for (int i = 0; i < A.Length; i++) {
     
            if (positionArray.Length >= A[i]) {
     
                if (positionArray[A[i]] == false)
                    jumpCounter--;
     
                if (jumpCounter == 0)
                    return i;
     
                positionArray[A[i]] = true;
            }
     
        }
     
        return -1;
    }
}
