namespace LeetCode.Solutions.Array.XORQueriesOfSubarray;

public static class _1310_XORQueriesOfSubarray
{
    public static int[] Solution(int[] arr, int[][] queries)
    {
        var prefixArr = new int[arr.Length + 1];
        for (int i = 0; i < arr.Length; i++)
            prefixArr[i + 1] = prefixArr[i] ^ arr[i];

        var result = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            var left = queries[i][0];
            var right = queries[i][1];

            result[i] = left == right
                ? arr[left]
                : prefixArr[left] ^ prefixArr[right + 1];
        }

        return result;
    }
}

public static class _1310_XORQueriesOfSubarrayTestCases
{
    public static (int[] Arr, int[][] Queries) Test_1 { get; } = ([1, 3, 4, 8], [[0, 1], [1, 2], [0, 3], [3, 3]]);
    public static (int[] Arr, int[][] Queries) Test_2 { get; } = ([16], [[0, 0], [0, 0], [0, 0]]);
}