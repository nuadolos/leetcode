namespace LeetCode.Solutions.SlidingWindow.SummaryRanges;

public static class _228_SummaryRanges
{
    public static IList<string> Solution(int[] nums)
    {
        var result = new List<string>();
        if (nums.Length == 0)
            return result;

        int left = 0, right = 0;
        while (left < nums.Length)
        {
            while (right + 1 < nums.Length && nums[right] + 1 == nums[right + 1])
                right++;

            result.Add(left == right
                ? nums[left].ToString()
                : nums[left].ToString() + "->" + nums[right].ToString());

            left = right = right + 1;
        }

        return result;
    }
}

public static class _228_SummaryRangesTestCases
{
    public static int[] Test_1 { get; } = [0, 1, 2, 4, 5, 7];
    public static int[] Test_2 { get; } = [0, 2, 3, 4, 6, 8, 9];
}