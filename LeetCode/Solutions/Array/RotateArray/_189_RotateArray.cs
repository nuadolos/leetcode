namespace LeetCode.Solutions.Array.RotateArray;

public static class _189_RotateArray
{
    public static void Solution(int[] nums, int k)
    {
        k %= nums.Length;
        ReverseArray(nums, 0, nums.Length - 1);
        ReverseArray(nums, 0, k - 1);
        ReverseArray(nums, k, nums.Length - 1);
    }

    private static void ReverseArray(int[] nums, int start, int end)
    {
        for (int i = start, j = end; i < j; i++, j--)
            (nums[i], nums[j]) = (nums[j], nums[i]);
    }
}

public static class _189_RotateArrayTestCases
{
    public static (int[] Nums, int K) Test_1 { get; } = ([1, 2, 3, 4, 5, 6, 7], 3);
}