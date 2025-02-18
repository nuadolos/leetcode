namespace LeetCode.Solutions.HashTable.TwoSum;

public static class _1_TwoSum
{
    public static int[] Solution(int[] nums, int target)
    {
        var dictionary = new Dictionary<int, int>();

        for (int firstIndex = 0; firstIndex < nums.Length; firstIndex++)
        {
            var num = nums[firstIndex];
            if (dictionary.TryGetValue(target - num, out var secondIndex))
                return [firstIndex, secondIndex];

            dictionary[num] = firstIndex;
        }

        throw new NotSupportedException();
    }
}

public static class _1_TwoSumTestCases
{
    public static (int[] Nums, int Target) Test_1 { get; } = ([2, 7, 11, 15], 9);
}