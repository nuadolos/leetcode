namespace LeetCode.Solutions.TwoPointers.MoveZeroes;

public static class _283_MoveZeroes
{
    public static void Solution(int[] nums)
    {
        int slow = 0;
        for (int fast = 0; fast < nums.Length; fast++)
        {
            if (nums[fast] == 0)
                continue;

            (nums[slow], nums[fast]) = (nums[fast], nums[slow]);
            slow++;
        }
    }
}

public static class _283_MoveZeroesTestCases
{
    public static int[] Test_1 { get; } = [0, 1, 0, 3, 12];
    public static int[] Test_2 { get; } = [0, 0, 0];
}