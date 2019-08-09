using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
    int N = A.Length;

    

    int size = 0;

    int candidate = -1;

    int candidateIndex = -1;

    

    for (int i = 0; i < N; i++) {

        if (size == 0) {

            candidate = A[i];

            candidateIndex = i;

            size++;

        } else {

            if (candidate != A[i]) {

                size--;

            } else {

                size++;

            }

        }

    }

    

    if (size <= 0) {

        return -1;

    }

    

    int counter = 0;

    

    for (int i = 0; i < N; i++) {

        if (candidate == A[i]) {

            counter++;

        }

    }

     

    if (counter > (N/2)) {

        return candidateIndex;

    }

    

    return -1;
    }
}
