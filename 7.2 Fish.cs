using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A, int[] B) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int N = A.Length;

        Stack<int> upStream = new Stack<int>();

        Stack<int> downStream = new Stack<int>();

        

        for (int i = 0; i < N; i++) {

            if ((B[i] == 0)) {            

                upStream.Push(A[i]);

                while (downStream.Count > 0) {
                    if (downStream.Peek() < A[i]) {
                        downStream.Pop();
                    } else {
                        upStream.Pop();
                        break;
                    }
                }
            } else {
                downStream.Push(A[i]);
            }
        }
        return downStream.Count + upStream.Count;
    }
}
