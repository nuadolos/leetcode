namespace LeetCode.Solutions.Graphs.NumberOfIslands;

public static class _200_NumberOfIslands
{
    private static (int X, int Y)[] Steps { get; } = [(1, 0), (0, -1), (-1, 0), (0, 1)];

    public static int Solution(char[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var used = new bool[m, n];
        var result = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (used[i, j] || grid[i][j] == '0')
                    continue;

                Dfs(i, j, used, grid);
                result++;
            }
        }

        return result;
    }

    private static void Dfs(int x, int y, bool[,] used, char[][] grid)
    {
        var stack = new Stack<(int X, int Y)>();
        stack.Push((x, y));
        used[x, y] = true;

        while (stack.TryPop(out var point))
        {
            foreach (var (stepX, stepY) in Steps)
            {
                (x, y) = (point.X + stepX, point.Y + stepY);
                if (!InBound(x, y, grid) || used[x, y] || grid[x][y] == '0')
                    continue;

                stack.Push((x, y));
                used[x, y] = true;
            }
        }
    }

    private static bool InBound(int x, int y, char[][] grid) =>
        x >= 0 && x < grid.Length && y >= 0 && y < grid[0].Length;
}

public static class _200_NumberOfIslandsTestCases
{
    public static char[][] Test_1 { get; } = 
    [
        ['1', '1', '1', '1', '0'],
        ['1', '1', '0', '1', '0'],
        ['1', '1', '0', '0', '0'],
        ['0', '0', '0', '0', '0']
    ];

    public static char[][] Test_2 { get; } =
    [
        ['1', '1', '0', '0', '0'],
        ['1', '1', '0', '0', '0'],
        ['0', '0', '1', '0', '0'],
        ['0', '0', '0', '1', '1']
    ];
}