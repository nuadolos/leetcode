## Success

```csharp
public class Solution
{
    private static int[][] Steps { get; } = [[1, 0], [-1, 0], [0, 1], [0, -1]];
    
    public void Solve(char[][] board)
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
```

***Оценка по времени:*** O(m * n)

***Оценка по памяти:*** O(m * n)

**Описание решения**

Изначально проходимся через `DFS` по всем граничных `O`-элементам (первый цикл - по вертикали, второй - по горизонтали). Помечаем такие `O`-элементы другим символом, в данном случае символом `S`, который будет участвовать для последующей замены элементов. После прохода по границам, начинаем итерацию по каждой графе. Если символ помечен, как `S`, это означает, что **островок нельзя пометить в `X`**, так как есть `O`-элемент, который нельзя окружить *(должны быть 4 соседних графа, не выходящие за границу матрицы)*. Поэтому такой символ помечается как `O`, а все остальные (и `O`, и `X`) просто помечаются как `X`.