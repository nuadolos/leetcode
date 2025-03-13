namespace LeetCode.Solutions.TwoPointers.TwoSum2InputArrayIsSorted;

public static class _167_TwoSum2InputArrayIsSorted
{
    public static int[] Solution(int[] numbers, int target)
    {
        int left = 0, right = numbers.Length - 1;
        while (left < right)
        {
            var sum = numbers[left] + numbers[right];
            if (sum == target)
                return [left + 1, right + 1];
            else if (sum > target)
                right--;
            else
                left++;
        }

        return [];
    }
}

public static class _167_TwoSum2InputArrayIsSortedTestCases
{
    public static (int[] Numbers, int Target) Test_1 { get; } = ([2, 7, 11, 15], 9);
    public static (int[] Numbers, int Target) Test_2 { get; } = ([2, 3, 4], 6);
}