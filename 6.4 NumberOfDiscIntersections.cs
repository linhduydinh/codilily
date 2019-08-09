using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int N = A.Length;

        

        if (N < 2) {

            return 0;

        }



        long[] leftEdges = new long[N];

        long[] rightEdges = new long[N];



        for (int i = 0; i < N; i++) {

            long r = (long)A[i];

            

            long left = i - r;

            leftEdges[i] = left;



            long right = i + r;

            rightEdges[i] = right;

        }


        Array.Sort(leftEdges);
        //quicksort(leftEdges, 0, N - 1);

        //quicksort(rightEdges, 0, N - 1);
        Array.Sort(rightEdges);


        int counter = 0;

        int previousCircles = 0;

        int leftP = 0;



        for (int rightP = 0; rightP < N; rightP++) {

            while ((leftP < N) && (leftEdges[leftP] <= rightEdges[rightP])) {

                leftP++;

                previousCircles++;

            }



            counter += --previousCircles;



            if (counter > 10000000) {

                return -1;

            }

        }

        return counter;
    }
}
