namespace LeetCode.Solutions.Array.MissingNumber;

public static class _268_MissingNumber
{
    public static int Solution(int[] nums)
    {
        var n = nums.Length;
        var sum = n * (n + 1) / 2;

        for (int i = 0; i < n; i++)
            sum -= nums[i];

        return sum;
    }
}

public static class _268_MissingNumberTestCases
{
    public static int[] Test_1 { get; } = [3, 0, 1];
    public static int[] Test_2 { get; } = [9, 6, 4, 2, 3, 5, 7, 0, 1];
}