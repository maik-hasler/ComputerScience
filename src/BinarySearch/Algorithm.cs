namespace BinarySearch;

public static class Algorithm
{
    public static int BinarySearch(int[] A, int T)
    {
        int L = 0;

        int R = A.Length - 1;

        int M = -1;

        while (L <= R)
        {
            M = (int)Math.Floor((decimal)((L + R) / 2));

            if (A[M] < T)
            {
                L = M + 1;

                continue;
            }

            if (A[M] > T)
            {
                R = M - 1;

                continue;
            }

            return M;
        }

        return M;
    }
}