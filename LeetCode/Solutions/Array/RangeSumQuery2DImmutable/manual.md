## Success

```csharp
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
```

***Оценка по времени:*** инициализация - O(n * m), запрос - O(1)

***Оценка по памяти:*** инициализация - O(n * m), запрос - O(1)

**Описание решения**

Заполняем префиксную матрицу, содержащая постепенное суммирование элементов с помощью определенной формулы на каждом шаге. Далее в методе `SumRegion` считаем сумму элементов в определенной фигуре. Также на индексах `_prefixMatrix[0][*]` и `_prefixMatrix[*][0]` всегда будет `0`, чтобы обойтись без доп. проверок `if`.