namespace LeetCode.Solutions.Easy;

public static class _1051_HeightChecker
{
    public static int Solution(int[] heights)
    {
        var counter = new int[101];

        foreach (var height in heights)
            counter[height]++;

        int index = 0, result = 0;
        for (int i = 1; i < counter.Length; i++)
        {
            while (counter[i] > 0)
            {
                if (heights[index] != i)
                    result++;

                index++;
                counter[i]--;
            }
        }

        return result;
    }
}
