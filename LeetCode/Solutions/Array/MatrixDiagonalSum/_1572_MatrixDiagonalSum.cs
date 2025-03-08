namespace LeetCode.Solutions.Array.MatrixDiagonalSum;

public static class _1572_MatrixDiagonalSum
{
    public static int Solution(int[][] mat)
    {
        int sum = 0;
        for (int i = 0, j = mat.Length - 1; i < mat.Length; i++, j--)
        {
            sum += mat[i][i];

            if (i != j)
                sum += mat[i][j];
        }

        return sum;
    }
}

public static class _1572_MatrixDiagonalSumTestCases
{
    public static int[][] Test_1 { get; } = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
    public static int[][] Test_2 { get; } = [[1, 1, 1, 1], [1, 1, 1, 1], [1, 1, 1, 1], [1, 1, 1, 1]];
}