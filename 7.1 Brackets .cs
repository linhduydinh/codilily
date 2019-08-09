using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(string S) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        Stack<char> stack = new Stack<char>();
        
        for(int i = 0; i < S.Length; i++)
        {
            if((S[i] == '{') || (S[i] == '[') || (S[i] == '('))
            {
                stack.Push(S[i]);
            }
            else
            {
                if(stack.Count == 0)
                {
                    return 0;
                }
                char peek = stack.Peek();
                if (((peek == '(') && (S[i] == ')')) || ((peek == '{') && (S[i] == '}')) || ((peek == '[') && (S[i] == ']'))) 
                {
                    stack.Pop();
                } else {
                    return 0;
                }
            }
        }
        return (stack.Count == 0) ? 1 : 0;
    }
}
