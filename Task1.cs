//int[] A = { 1, 3, 4, 2, 5 };
            //int[] A = { 2, 3, 4, 1, 5 };
            int[] A = { 2, 1, 3, 5, 4 };
            int count = 0;
            bool[] B = new bool[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                B[A[i] - 1] = true;
                bool check = true;
                for (int j = 0; j < A[i]; j++)
                {
                    if (B[j] == false)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    count++;
                }
            }
            return count;
