## Success

```csharp
public class Solution
{
    public int[] XorQueries(int[] arr, int[][] queries)
    {
        var prefixArr = new int[arr.Length + 1];
        for (int i = 0; i < arr.Length; i++)
            prefixArr[i + 1] = prefixArr[i] ^ arr[i];

        var result = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            var left = queries[i][0];
            var right = queries[i][1];

            result[i] = left == right
                ? arr[left]
                : prefixArr[left] ^ prefixArr[right + 1];
        }

        return result;
    }
}
```

***Оценка по времени:*** O(n * m)

***Оценка по памяти:*** O(n * m)

**Описание решения**

Заполняем изначально префиксный массив, в котором поэтапно выполняем `XOR` вместо суммирования. Далее пробегаем по запросам, используя промежутки `left` и `right`. Если они равны, то отдаем элемент из массива на том месте. Если запрашивает `left < right`, то выполняем получение результата с помощью формулы префиксного массива, где вместо вычитания используем тот же `XOR`.