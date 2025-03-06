namespace LeetCode.Solutions.Array.LongestContinuousIncreasingSubsequence;

public static class _674_LongestContinuousIncreasingSubsequence
{
    public static int Solution(int[] nums)
    {
        int count = 1, maxCount = 1;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i + 1] > nums[i])
            {
                count++;
                if (maxCount < count)
                    maxCount = count;
            }
            else
                count = 1;
        }

        return maxCount;
    }
}

public static class _674_LongestContinuousIncreasingSubsequenceTestCases
{
    public static int[] Test_1 { get; } = [1, 3, 5, 7];
    public static int[] Test_2 { get; } = [1, 3, 5, 4, 2, 3, 4, 5];
}