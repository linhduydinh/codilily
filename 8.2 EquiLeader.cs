using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        Stack<int> stack = new Stack<int>();
        
        for(int i = 0; i < A.Length; i++)
        {
            if(stack.Count == 0)
            {
                stack.Push(A[i]);
            }
            else
            {
                int peek = stack.Peek();
                if(A[i] == peek)
                {
                    stack.Push(A[i]);
                }
                else
                {
                    stack.Pop();
                }
            }
        }
        if(stack.Count == 0)
        {
            return 0;
        }
        
        int count = 0;
        
        for(int i = 0; i < A.Length; i++)
        {
            if(A[i] == stack.Peek())
            {
                count++;
            }
        }
        
        if(count <= A.Length /2)
        {
            return 0;
        }
        
        //let's count the number of equi leader.
        int lcnt = 0; //leader appeard until the index.
        int ans  = 0; //the number of equi leaders.
        int leader = stack.Peek();
        for (int i = 0; i < A.Length; i++){
            if (A[i] == leader){
                lcnt++;
            }
            //check if the current index is a equi leader
            int lelems = i + 1;
            if ((lcnt > lelems / 2) && ((count - lcnt) > (A.Length - lelems) / 2))
            {
                ans++;
            }
        }
        
        return ans;
    }
}
