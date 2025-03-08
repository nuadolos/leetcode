using static LeetCode.Solutions.Array.RangeSumQuery2DImmutable._304_RangeSumQuery2DImmutable;

namespace LeetCode.Solutions.Array.RangeSumQuery2DImmutable;

public static class _304_RangeSumQuery2DImmutable
{
    public static void Solution(string[] func, object[] args)
    {
        NumMatrix? numMatrix = null;

        for (int i = 0; i < func.Length; i++)
        {
            var functionName = func[i];

            if (functionName == nameof(NumMatrix))
            {
                var arg = (int[][])args[i];
                numMatrix = new NumMatrix(arg);
            }
            else if (functionName == nameof(NumMatrix.SumRegion))
            {
                if (numMatrix == null)
                    throw new InvalidCastException($"{nameof(numMatrix)} is not initialized");

                var arg = (int[])args[i];
                if (arg.Length != 4)
                    throw new InvalidOperationException($"{nameof(arg)} must be of size 4 elements");

                numMatrix.SumRegion(arg[0], arg[1], arg[2], arg[3]);
            }
        }
    }

    public class NumMatrix
    {
        private readonly int[][] _prefixMatrix;

        public NumMatrix(int[][] matrix)
        {
            var n = matrix.Length;
            var m = matrix[0].Length;

            _prefixMatrix = new int[n + 1][];
            _prefixMatrix[0] = new int[m + 1];

            for (int i = 0; i < n; i++)
            {
                _prefixMatrix[i + 1] = new int[m + 1];

                for (int j = 0; j < m; j++)
                    _prefixMatrix[i + 1][j + 1] = matrix[i][j]
                        + _prefixMatrix[i + 1][j]
                        + _prefixMatrix[i][j + 1]
                        - _prefixMatrix[i][j];
            }
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            return _prefixMatrix[row2 + 1][col2 + 1]
                - _prefixMatrix[row2 + 1][col1]
                - _prefixMatrix[row1][col2 + 1]
                + _prefixMatrix[row1][col1];
        }
    }
}

public static class _304_RangeSumQuery2DImmutableTestCases
{
    public static (string[] Func, object[] Args) Test_1 { get; } =
    (
        Func: [nameof(NumMatrix), nameof(NumMatrix.SumRegion), nameof(NumMatrix.SumRegion), nameof(NumMatrix.SumRegion)],
        Args:
        [
            new int[][] { [3, 0, 1, 4, 2], [5, 6, 3, 2, 1], [1, 2, 0, 1, 5], [4, 1, 0, 1, 7], [1, 0, 3, 0, 5] },
            new int[] { 2, 1, 4, 3 }, 
            new int[] {1, 1, 2, 2 }, 
            new int[] {1, 2, 2, 4 }
        ]
    );
}