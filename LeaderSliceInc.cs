using System;
using System.Linq;
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int K, int M, int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int N = A.Length;
        List<int[]> arrayList = new List<int[]>();
            arrayList.Add(A);

            for (int i = 2; i <= M; i++)
            {
                int[] temp = new int[N];
                for (int j = 0; j < N; j++)
                {
                    if (A[j] < i)
                    {
                        temp[j] = A[j] + 1;
                    }
                    else
                    {
                        temp[j] = A[j];
                    }
                }
                arrayList.Add(temp);
            }

            int[] B = new int[K];

            for (int k = 0; k < arrayList.Count; k++)
            {
                Stack<int> stack = new Stack<int>();
                int[] temp = new int[N];
                temp = arrayList[k];

                for (int i = 0; i < temp.Length; i++)
                {
                    if (stack.Count == 0)
                    {
                        stack.Push(temp[i]);
                    }
                    else
                    {
                        int peek = stack.Peek();
                        if (temp[i] == peek)
                        {
                            stack.Push(temp[i]);
                        }
                        else
                        {
                            stack.Pop();
                        }
                    }
                }
                if (stack.Count == 0)
                {
                    continue;
                }

                int count = 0;

                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] == stack.Peek())
                    {
                        count++;
                    }
                }

                if (count <= temp.Length / 2)
                {
                    continue;
                }

                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] == stack.Peek())
                    {
                        B[k] = temp[i];
                        break;
                    }
                }

            }

            return B.Where(x => x > 0).ToArray();
    }
}
