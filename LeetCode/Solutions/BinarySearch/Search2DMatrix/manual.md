## Success

```csharp
public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
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
```

***Оценка по времени:*** O(log (m * n))

***Оценка по памяти:*** O(1)

**Описание решения**

Используем тот же бинарный поиск, но представляем, что матрица является одномерным массивом, ведь, соединив последовательно все строки, получится отсортированный по возрастанию массив. Таким образом, преобразуем обращение с матрицей в одномерный массив, вычисляя строки по формуле `index / n`, а колонки - `index % n`. В конце получаем левый указатель одномерного массива, ищем этот элемент в матрице и сравниваем с `target`.