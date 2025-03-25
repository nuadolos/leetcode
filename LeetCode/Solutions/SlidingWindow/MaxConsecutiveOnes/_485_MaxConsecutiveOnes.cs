namespace LeetCode.Solutions.SlidingWindow.MaxConsecutiveOnes;

public static class _485_MaxConsecutiveOnes
{
    public static int Solution(int[] nums)
    {
        int left = 0, right = 0, maxSequence = 0;
        while (left < nums.Length)
        {
            while (right + 1 < nums.Length && nums[right] == nums[right + 1])
                right++;

            if (nums[right] == 1)
                maxSequence = Math.Max(maxSequence, right - left + 1);

            left = ++right;
        }

        return maxSequence;
    }
}

public static class _485_MaxConsecutiveOnesTestCases
{
    public static int[] Test_1 { get; } = [1, 1, 0, 1, 1, 1];
    public static int[] Test_2 { get; } = [1, 0, 1, 1, 0, 1];
}