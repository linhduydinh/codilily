using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] H) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int N = H.Length;

        

        Stack<int> stack = new Stack<int>();

        stack.Push(H[0]);

        

        int blocks = 1;

        

        for (int i = 1; i < N; i++) {

            int currentHeight = 0;

            

            if (stack.Count > 0) {

                currentHeight = stack.Peek();

            }

            

            if (currentHeight > H[i]) {

                stack.Pop();

                i--;

            } else if (currentHeight < H[i]) {

                stack.Push(H[i]);

                blocks++;

            }

        }

        

        return blocks;
    }
}
