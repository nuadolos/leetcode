namespace LeetCode.Solutions.BinarySearch.FindFirstAndLastPositionOfElementInSortedArray;

public static class _34_FindFirstAndLastPositionOfElementInSortedArray
{
    public static int[] Solution(int[] nums, int target)
    {
        int[] result = [-1, -1];
        if (nums.Length == 0)
            return result;

        result[0] = SearchStartPosition(nums, target);
        if (result[0] != -1)
            result[1] = SearchEndPosition(nums, target);

        return result;
    }

    private static int SearchStartPosition(int[] nums, int target)
    {
        bool Good(int num) =>
            num < target;

        int l = -1, r = nums.Length - 1;
        while (r - l > 1)
        {
            int m = (l + r) / 2;
            if (Good(nums[m]))
                l = m;
            else
                r = m;
        }

        return nums[r] == target ? r : -1;
    }

    private static int SearchEndPosition(int[] nums, int target)
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

        return nums[l] == target ? l : -1;
    }
}

public static class _34_FindFirstAndLastPositionOfElementInSortedArrayTestCases
{
    public static (int[] Nums, int Target) Test_1 { get; } = ([5, 7, 7, 8, 8, 10], 8);
    public static (int[] Nums, int Target) Test_2 { get; } = ([5, 7, 7, 8, 8, 10], 6);
}