using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(string S) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int N = S.Length;

        int counter = 0;

        

        for (int i = 0; i < N; i++) {

            if (S[i] == '(') {

                counter++;

            } else if (S[i] == ')') {

                if (--counter < 0) {

                    return 0;

                }

            }

        }

        

        return ((counter == 0) ? 1 : 0);
    }
}
