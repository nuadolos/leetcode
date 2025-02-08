namespace LeetCode.Solutions.Easy;

public static class _941_ValidMountainArray
{
    public static bool Solution(int[] arr)
    {
        if (arr.Length < 3)
            return false;

        var i = 0;

        while (i + 1 < arr.Length && arr[i] < arr[i + 1])
            i++;

        if (i == 0 || i == arr.Length - 1)
            return false;

        while (i + 1 < arr.Length && arr[i] > arr[i + 1])
            i++;

        return i + 1 == arr.Length;
    }
}
