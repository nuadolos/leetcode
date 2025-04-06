namespace LeetCode.Solutions.BinarySearch.SearchInRotatedSortedArray;

public static class _33_SearchInRotatedSortedArray
{
    public static int Solution(int[] nums, int target)
    {
        bool Good(int num) =>
            num <= target;

        var offset = FindOffset(nums);

        int n = nums.Length;
        int l = offset, r = nums.Length + offset;
        while (r - l > 1)
        {
            int m = (l + r) / 2;

            if (Good(nums[m % n]))
                l = m;
            else
                r = m;
        }

        var realLeft = l % n;
        return nums[realLeft] == target ? realLeft : -1;
    }

    private static int FindOffset(int[] nums)
    {
        bool Good(int num) =>
            num > nums[^1];

        int l = -1, r = nums.Length - 1;
        while (r - l > 1)
        {
            int m = (l + r) / 2;

            if (Good(nums[m]))
                l = m;
            else
                r = m;
        }

        return r;
    }
}

public static class _33_SearchInRotatedSortedArrayTestCases
{
    public static (int[] Nums, int Target) Test_1 { get; } = ([4, 5, 6, 7, 0, 1, 2], 0);
    public static (int[] Nums, int Target) Test_2 { get; } = ([4, 5, 6, 7, 0, 1, 2], 3);
}