## Success

```csharp
public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        if (intervals.Length < 2)
            return intervals;
        
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        
        int start = intervals[0][0], end = intervals[0][1];
        var result = new List<int[]>();
        for (int i = 1; i < intervals.Length; i++)
        {
            var curr = intervals[i];
            
            if (Math.Max(start, curr[0]) <= Math.Min(end, curr[1]))
            {
                end = Math.Max(end, curr[1]);
                continue;
            }

            result.Add([start, end]);
            (start, end) = (curr[0], curr[1]);
        }
        
        result.Add([start, end]);
        
        return [.. result];
    }
}
```

***Оценка по времени:*** O(n log n)

Так как изначальная сортировка массива `intervals` занимает `n * log n`.

***Оценка по памяти:*** O(n)

**Описание решения**

Изначально сортируем массив интервалов по начальной координате. Таким образом, сможем находить пересечения двух интервалов. Далее проходимся по массиву, проинициализировав стартовую точку - с первого интервала. В итерации проверяем наличие пересечения. Если пересечение есть, то просто смещаем `end`, в ином случае - добавляем законченный интервал в результат, а также перезаписываем `start` и `end` на значения текущего интервала. В конце добавляем еще незаписанный последний интервал.