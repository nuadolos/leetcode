namespace LeetCode.Solutions.Medium;

public static class _54_SpiralMatrix
{
    public static IList<int> Solution(int[][] matrix)
    {
        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            return [];

        var m = matrix.Length;
        var n = matrix[0].Length;

        var left = 0;
        var top = 0;
        var right = n - 1;
        var bottom = m - 1;
        var numberOfElements = m * n;

        var result = new List<int>();
        while (result.Count < numberOfElements)
        {
            for (var i = left; i <= right && result.Count < numberOfElements; i++)
            {
                result.Add(matrix[top][i]);
            }

            top++;

            for (var i = top; i <= bottom && result.Count < numberOfElements; i++)
            {
                result.Add(matrix[i][right]);
            }

            right--;

            for (var i = right; i >= left && result.Count < numberOfElements; i--)
            {
                result.Add(matrix[bottom][i]);
            }

            bottom--;

            for (var i = bottom; i >= top && result.Count < numberOfElements; i--)
            {
                result.Add(matrix[i][left]);
            }

            left++;
        }

        return result;
    }
}
