## Success

### DFS и BFS

- DFS (поиск в глубину) сначала идёт как можно дальше по одной ветке, пока не упрётся в конец, и только потом возвращается назад и пробует другие пути.

- BFS (поиск в ширину) сразу обходит всех соседей текущей вершины, затем их соседей и так далее — слой за слоем.

### Вариант 1 (DFS с рекурсией)

```csharp
public class Solution
{
    public int NumIslands(char[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        
        var used = new bool[m,n];
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
        if (!InBound(x, y, grid) || used[x, y] || grid[x][y] == '0')
            return;
            
        used[x, y] = true;
        
        Dfs(x + 1, y, used, grid);
        Dfs(x - 1, y, used, grid);  
        Dfs(x, y + 1, used, grid);  
        Dfs(x, y - 1, used, grid);   
    }
    
    private static bool InBound(int x, int y, char[][] grid) =>
        x >= 0 && x < grid.Length && y >= 0 && y < grid[0].Length;
}
```

***Оценка по времени:*** O(m * n)

***Оценка по памяти:*** O(m * n)

**Описание решения**

Инициализируем массив `used`, который нужен для проверки, были ли мы уже на клетке или еще нет. Далее начинаем поиск первого островка, который еще не был посещен. Далее применяем к нему `DFS`. Внутри метода `Dfs` делаем проверку, подходит ли текущая клетка всем условиям, а далее помечаем ее как **посещенную** и проходимся по ее соседям рекурсивно, пока не пройдем весь островок. После обхода полного островка помечаем, что мы его прошли, прибавляя к результату единицу.

### Вариант 2 (DFS без рекурсии)

```csharp
public class Solution
{
    private static (int X, int Y)[] Steps { get; } = [(1, 0), (0, -1), (-1, 0), (0, 1)];

    public int NumIslands(char[][] grid)
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
```

***Оценка по времени:*** O(m * n)

***Оценка по памяти:*** O(m * n)

**Описание решения**

То же самое решение, но без рекурсии, используя **стек**.

### Вариант 3 (BFS без рекурсии)

```csharp
public class Solution
{
    private readonly static (int X, int Y)[] _steps = [(1, 0), (0, -1), (-1, 0), (0, 1)];

    public int NumIslands(char[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        
        var used = new bool[m,n];
        var result = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (used[i, j] || grid[i][j] == '0')
                    continue;
                    
                Bfs(i, j, used, grid);
                result++;
            }   
        }
        
        return result;
    }
    
    private static void Bfs(int x, int y, bool[,] used, char[][] grid)
    {  
        var queue = new Queue<(int X, int Y)>();
        queue.Enqueue((x, y));
        used[x, y] = true;

        while (queue.TryDequeue(out var point))
        {
            foreach (var step in _steps)
            {
                var (newX, newY) = (point.X + step.X, point.Y + step.Y);
                if (!InBound(newX, newY, grid) 
                    || used[newX, newY] 
                    || grid[newX][newY] == '0')
                    continue;

                queue.Enqueue((newX, newY));
                used[newX, newY] = true;
            }
        }
    }
    
    private static bool InBound(int x, int y, char[][] grid) =>
        x >= 0 && x < grid.Length && y >= 0 && y < grid[0].Length;
}
```

***Оценка по времени:*** O(m * n)

***Оценка по памяти:*** O(m * n)

**Описание решения**

То же самое решение, но уже используется `BFS`, который использует вместо стека **очередь**.