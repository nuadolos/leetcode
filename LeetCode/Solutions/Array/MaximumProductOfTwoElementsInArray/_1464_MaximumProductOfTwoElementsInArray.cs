namespace LeetCode.Solutions.Array.MaximumProductOfTwoElementsInArray;

public static class _1464_MaximumProductOfTwoElementsInArray
{
    public static int Solution(int[] nums)
    {
        int max1 = 0, max2 = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (num > max1)
                (max1, max2) = (num, max1);
            else if (num > max2)
                max2 = num;
        }

        return (max1 - 1) * (max2 - 1);
    }
}

public static class _1464_MaximumProductOfTwoElementsInArrayTestCases
{
    public static int[] Test_1 { get; } = [10, 2, 5, 2];
    public static int[] Test_2 { get; } = [3, 7];
}