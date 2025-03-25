namespace LeetCode.Solutions.SlidingWindow.SummaryRanges;

public static class _228_SummaryRanges
{
    public static IList<string> Solution(int[] nums)
    {
        var result = new List<string>();
        if (nums.Length == 0)
            return result;

        int beginNum = nums[0], endNum = beginNum;
        for (int i = 1; i < nums.Length; i++)
        {
            var curr = nums[i];

            if (endNum + 1 != curr)
            {
                result.Add(beginNum == endNum
                    ? beginNum.ToString()
                    : beginNum.ToString() + "->" + endNum.ToString());
                beginNum = curr;
            }

            endNum = curr;
        }

        result.Add(beginNum == endNum
            ? beginNum.ToString()
            : beginNum.ToString() + "->" + endNum.ToString());

        return result;
    }
}

public static class _228_SummaryRangesTestCases
{
    public static int[] Test_1 { get; } = [0, 1, 2, 4, 5, 7];
    public static int[] Test_2 { get; } = [0, 2, 3, 4, 6, 8, 9];
}