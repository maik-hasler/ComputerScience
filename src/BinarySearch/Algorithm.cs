namespace BinarySearch;

public static class Algorithm
{
    public static int BinarySearch(int[] array, int target)
    {
        int leftBoundary = 0;

        int rightBoundary = array.Length - 1;

        while (leftBoundary <= rightBoundary)
        {
            int pointer = (int)Math.Floor((decimal)((leftBoundary + rightBoundary) / 2));

            if (array[pointer] < target)
            {
                leftBoundary = pointer + 1;

                continue;
            }

            if (array[pointer] > target)
            {
                rightBoundary = pointer - 1;

                continue;
            }

            return pointer;
        }

        throw new Exception();
    }
}