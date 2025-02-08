namespace LeetCode.Solutions.Easy;

public static class _1346_CheckIfNAndItsDoubleExist
{
    public static bool Solution(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                var arrI = arr[i];
                var arrJ = arr[j];

                if (arrI == 2 * arrJ || arrJ == 2 * arrI)
                    return true;
            }
        }

        return false;
    }
}
