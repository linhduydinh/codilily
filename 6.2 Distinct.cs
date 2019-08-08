using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        Array.Sort(A);
        int distinct = 1;
        if (A.Length == 0) 
        {
	        return 0;
        }

	    if (A.Length == 1) 
	    {
	        return 1;
	    }
	    
        for(int i = 0; i < A.Length - 1; i++)
        {
            if(A[i] == A[i+1])
            {
                continue;
            }
            else
            {
                distinct += 1;
            }
        }
        return distinct;
    }
}
