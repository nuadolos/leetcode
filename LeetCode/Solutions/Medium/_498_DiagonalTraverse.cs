namespace LeetCode.Solutions.Medium;

public static class _498_DiagonalTraverse
{
    public static int[] Solution(int[][] mat)
    {
        if (mat == null || mat.Length == 0 || mat[0].Length == 0)
            return [];

        var m = mat.Length;
        var n = mat[0].Length;

        var result = new int[m * n];
        var index = 0;

        for (int sum = 0; sum < m + n - 1; sum++)
        {
            if (sum % 2 == 0)
            {
                for (int row = Math.Min(sum, m - 1); row >= 0 && sum - row < n; row--)
                {
                    result[index++] = mat[row][sum - row];
                }
            }
            else
            {
                for (int col = Math.Min(sum, n - 1); col >= 0 && sum - col < m; col--)
                {
                    result[index++] = mat[sum - col][col];
                }
            }
        }

        return result;
    }
}
