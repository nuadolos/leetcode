namespace LeetCode.Solutions.Array.FindPivotIndex;

public static class _724_FindPivotIndex
{
    public static int Solution(int[] nums)
    {
        var sumRight = 0;
        for (int i = 0; i < nums.Length; i++)
            sumRight += nums[i];

        var sumLeft = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sumRight -= nums[i];

            if (sumLeft == sumRight)
                return i;

            sumLeft += nums[i];
        }

        return -1;
    }
}

public static class _724_FindPivotIndexTestCases
{
    public static int[] Test_1 { get; } = [1, 7, 3, 6, 5, 6];
    public static int[] Test_2 { get; } = [1, 2, 3];
}