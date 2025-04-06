namespace LeetCode.Solutions.BinarySearch.BinarySearch;

public static class _704_BinarySearch
{
    public static int Solution(int[] nums, int target)
    {
        bool Good(int num) =>
            num <= target;

        int l = 0, r = nums.Length;
        while (r - l > 1)
        {
            int m = (l + r) / 2;
            if (Good(nums[m]))
                l = m;
            else
                r = m;
        }

        return nums[l] == target
            ? l
            : -1;
    }
}

public static class _704_BinarySearchTestCases
{
    public static (int[] Nums, int Target) Test_1 { get; } = ([-1, 0, 3, 5, 9, 12], 9);
    public static (int[] Nums, int Target) Test_2 { get; } = ([-1, 0, 3, 5, 9, 12], 2);
}