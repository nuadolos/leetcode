namespace LeetCode.Solutions.Medium;

public static class _167_TwoSum2InputArrayIsSorted
{
    public static int[] Solution(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

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
