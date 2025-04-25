namespace LeetCode.Solutions.Graphs.SurroundedRegions;

public static class _130_SurroundedRegions
{
    private static int[][] Steps { get; } = [[1, 0], [-1, 0], [0, 1], [0, -1]];

    public static void Solution(char[][] board)
    {
        var m = board.Length;
        var n = board[0].Length;

        for (var i = 0; i < m; i++)
        {
            if (board[i][0] == 'O')
                DFS(i, 0, board);

            if (board[i][n - 1] == 'O')
                DFS(i, n - 1, board);
        }

        for (var j = 0; j < n; j++)
        {
            if (board[0][j] == 'O')
                DFS(0, j, board);

            if (board[m - 1][j] == 'O')
                DFS(m - 1, j, board);
        }

        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                board[i][j] = board[i][j] == 'S' ? 'O' : 'X';
    }

    private static void DFS(int x, int y, char[][] board)
    {
        if (!InBound(x, y, board) || board[x][y] != 'O')
            return;

        board[x][y] = 'S';

        foreach (var step in Steps)
        {
            var (newX, newY) = (x + step[0], y + step[1]);
            DFS(newX, newY, board);
        }
    }

    private static bool InBound(int x, int y, char[][] board) =>
        x >= 0 && x < board.Length && y >= 0 && y < board[0].Length;
}

public static class _130_SurroundedRegionsTestCases
{
    public static char[][] Test_1 { get; } = [['X', 'X', 'X', 'X'], ['X', 'O', 'O', 'X'], ['X', 'X', 'O', 'X'], ['X', 'O', 'X', 'X']];
    public static char[][] Test_2 { get; } = [['X', 'X', 'X', 'X'], ['X', 'O', 'O', 'X'], ['X', 'O', 'O', 'X'], ['X', 'O', 'X', 'X']];
}