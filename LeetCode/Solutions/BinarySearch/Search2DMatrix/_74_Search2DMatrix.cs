namespace LeetCode.Solutions.BinarySearch.Search2DMatrix;

public static class _74_Search2DMatrix
{
    public static bool Solution(int[][] matrix, int target)
    {
        bool Good(int num) =>
            num <= target;

        int l = 0, r = matrix.Length * matrix[0].Length;
        while (r - l > 1)
        {
            int m = (l + r) / 2;

            if (Good(GetElFromMatrix(matrix, m)))
                l = m;
            else
                r = m;
        }

        return GetElFromMatrix(matrix, l) == target;
    }

    private static int GetElFromMatrix(int[][] matrix, int index)
    {
        int n = matrix[0].Length;
        return matrix[index / n][index % n];
    }
}

public static class _74_Search2DMatrixTestCases
{
    public static (int[][] Matrix, int Target) Test_1 { get; } = 
        ([[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], 3);

    public static (int[][] Matrix, int Target) Test_2 { get; } =
        ([[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], 13);
}