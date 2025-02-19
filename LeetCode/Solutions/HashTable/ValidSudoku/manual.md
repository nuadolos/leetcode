## Success

### Вариант 1

```csharp
public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        var rows = new HashSet<(int, int)>();
        var columns = new HashSet<(int, int)>();
        var blocks = new HashSet<(int, int)>();

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                var value = board[i][j];
                if (value == '.')
                    continue;

                if (!columns.Add((i, value))
                    || !rows.Add((j, value))
                    || !blocks.Add((i / 3 * 3 + j / 3, value)))
                    return false;
            }
        }

        return true;
    }
}
```

***Оценка по времени:*** O(n^2)

Так как проходимся по всей матрице. Но в данном контексте мы всегда имеем матрицу `9x9`, поэтому `O(1)`, так как выполняется всегда за то же самое время.

***Оценка по памяти:*** O(n^2)

Также используем дополнительно `HashSet`, который копируют колонки, строки и ячейки `3x3`. Если их при каждой правильно чистить, то можно добиться `O(n)`. Также в данном выделенная память будет включать 3 хеш-таблица с максимальной длиной `9x9` элементов. 

**Описание решения**

Инициализируем хеш-таблицу для строк (хранит номер строки и значение), для колонок (хранит номер колонки и значение) и для ячеек `3x3` (хранит номер ячейки и значение). Далее проходимся по каждой клетке, записывая и проверяя каждую строку, колонку и ячейку. Если значение уже есть в хеш-таблице строк, колонок или ячеек, значит судоку не валиден.

### Вариант 2 (оптимальное решение)

```csharp
public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        var columnsLength = board.Length;
        var rowsLength = board[0].Length;

        var rows = new bool[columnsLength, rowsLength];
        var columns = new bool[columnsLength, rowsLength];
        var boxes = new bool[columnsLength, rowsLength];

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                var value = board[i][j];
                if (value == '.')
                    continue;

                var num = value - '1';
                var boxIndex = i / 3 * 3 + j / 3;

                if (!columns[i, num]
                    || !rows[j, num]
                    || !boxes[boxIndex, num])
                    return false;

                columns[i, num] = true;
                rows[j, num] = true;
                boxes[boxIndex, num] = true;
            }
        }

        return true;
    }
}
```

***Оценка по времени:*** O(n^2)

***Оценка по памяти:*** O(n^2)

**Описание решения**

Тоже самое, что и **вариант 1**, но использует массив `bool`.