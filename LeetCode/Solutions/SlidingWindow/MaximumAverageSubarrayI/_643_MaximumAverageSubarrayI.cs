namespace LeetCode.Solutions.SlidingWindow.MaximumAverageSubarrayI;

public static class _643_MaximumAverageSubarrayI
{
    public static double Solution(int[] nums, int k)
    {
        if (nums.Length == 1)
            return nums[0];

        int l = 0, r = -1;
        double sum = 0, maxAverage = double.MinValue;
        while (l + k <= nums.Length)
        {
            while (r + 1 < nums.Length && r + 1 < l + k)
                sum += nums[++r];

            var average = sum / k;
            if (maxAverage < average)
                maxAverage = average;

            sum -= nums[l++];
        }

        return maxAverage;
    }
}

public static class _643_MaximumAverageSubarrayITestCases
{
    public static (int[] Nums, int K) Test_1 { get; } = ([1, 12, -5, -6, 50, 3], 4);
    public static (int[] Nums, int K) Test_2 { get; } = ([5], 1);
}