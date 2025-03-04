namespace LeetCode.Solutions.Array.SubarraySumEqualsK;

public static class _560_SubarraySumEqualsK
{
    public static int Solution(int[] nums, int k)
    {
        int sum = 0, subarrayCount = 0;
        var prefixSumCounter = new Dictionary<int, int>
        {
            [0] = 1
        };

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            if (prefixSumCounter.TryGetValue(sum - k, out var prefixSumCount))
                subarrayCount += prefixSumCount;

            prefixSumCounter.TryGetValue(sum, out var sumCount);
            prefixSumCounter[sum] = sumCount + 1;
        }

        return subarrayCount;
    }
}

public static class _560_SubarraySumEqualsKTestCases
{
    public static (int[] Nums, int K) Test_1 { get; } = ([7, 3, 1, 5, 5, 5], 10);
    public static (int[] Nums, int K) Test_2 { get; } = ([0, 0, 0, 0], 0);
}