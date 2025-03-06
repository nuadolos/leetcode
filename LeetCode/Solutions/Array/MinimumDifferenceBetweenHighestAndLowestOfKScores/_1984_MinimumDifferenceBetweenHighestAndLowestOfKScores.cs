namespace LeetCode.Solutions.Array.MinimumDifferenceBetweenHighestAndLowestOfKScores;

public static class _1984_MinimumDifferenceBetweenHighestAndLowestOfKScores
{
    public static int Solution(int[] nums, int k)
    {
        if (k == 1)
            return 0;

        System.Array.Sort(nums);

        var minDifference = nums[^1];
        for (int i = 0; i <= nums.Length - k; i++)
        {
            var difference = nums[i + k - 1] - nums[i];
            if (minDifference > difference)
                minDifference = difference;
        }

        return minDifference;
    }
}

public static class _1984_MinimumDifferenceBetweenHighestAndLowestOfKScoresTestCases
{
    public static (int[] Nums, int K) Test_1 { get; } = ([9, 4, 1, 7], 2);
    public static (int[] Nums, int K) Test_2 { get; } = ([90, 89, 88, 87], 4);
}