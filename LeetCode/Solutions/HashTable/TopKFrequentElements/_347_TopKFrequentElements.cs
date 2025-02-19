namespace LeetCode.Solutions.HashTable.TopKFrequentElements;

public static class _347_TopKFrequentElements
{
    public static int[] Solution(int[] nums, int k)
    {
        int min = nums[0], max = nums[0];

        foreach (int num in nums)
        {
            if (min > num)
                min = num;
            else if (max < num)
                max = num;
        }

        var counter = new int[max - min + 1];
        foreach (int num in nums)
            counter[num - min]++;

        var result = new int[k];
        for (int i = 0; i < k; i++)
        {
            int maxCount = -1, maxIndex = -1;

            for (int j = 0; j < counter.Length; j++)
            {
                var count = counter[j];
                if (maxCount < count)
                    (maxCount, maxIndex) = (count, j);
            }

            result[i] = maxIndex + min;
            counter[maxIndex] = -1;
        }

        return result;
    }
}

public static class _347_TopKFrequentElementsTestCases
{
    public static (int[] Nums, int K) Test_1 { get; } = ([1, 2], 2);
    public static (int[] Nums, int K) Test_2 { get; } = ([1, 1, 1, 2, 2, 3], 2);
}