# Binary search
Binary Search is a searching algorithm for finding an element's position in a sorted array.

# Procedure
Given an array $A$ of $n$ elements with values $A_0$, $A_1$, $A_2$, ... $A_{n-1}$ sorted such that $A_0$ $\leq$ $A_1$ $\leq$ $A_2$ $\leq$ ... $\leq$ $A_{n-1}$ and target value $T$.

1. Set $L$ to $0$ and $R$ to $n-1$.
2. If $L > R$, the search terminates as unsuccessful.
3. Set $m$ to the floor of $\frac{L+R}{2}$, which is the greatest integer less than or equal to $\frac{L+R}{2}$.
4. If $A_m < T$, set $L$ to $m+1$ and go to step 2.
5. If $A_m > T$, set $R$ to $m-1$ and go to step 2.
6. Now $A_m = T$, the search is done. Return $m$.

# Code example
```csharp
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
```