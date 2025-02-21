namespace LeetCode.Solutions.HashTable.HIndex;

public static class _274_HIndex
{
    public static int Solution(int[] citations)
    {
        var n = citations.Length;
        var counter = new int[n + 1];
        foreach (int num in citations)
        {
            var actIndex = num > n ? n : num;
            counter[actIndex]++;
        }

        var total = 0;
        for (int h = counter.Length - 1; h >= 0; h--)
        {
            total += counter[h];
            if (total >= h)
                return h;
        }

        return 0;
    }
}

public static class _274_HIndexTestCases
{
    public static int[] Test_1 { get; } = [3, 0, 6, 1, 5];
    public static int[] Test_2 { get; } = [1, 3, 1];
}