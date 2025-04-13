## Success

```csharp
public class Solution
{
    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
    {
        if (firstList.Length == 0 || secondList.Length == 0)
            return [];
            
        int firstIndex = 0, secondIndex = 0;
        var result = new List<int[]>();
        while (firstIndex < firstList.Length
            && secondIndex < secondList.Length)
        {
            var firstInterval = firstList[firstIndex];
            var secondInterval = secondList[secondIndex];
            
            var a = Math.Max(firstInterval[0], secondInterval[0]);
            var b = Math.Min(firstInterval[1], secondInterval[1]);            
            
            if (a <= b)
                result.Add([a, b]);

            if (firstInterval[1] < secondInterval[1])
                firstIndex++;
            else
                secondIndex++;
        }
        
        return [.. result];
    }
}
```

***Оценка по времени:*** O(n + m)

***Оценка по памяти:*** O(max(n,m))

`min(n,m)` не подходит, так как, например, 1 список содержит только один длинный интервал, а второй - много маленьких. Если большой интервал перекрывает все маленькие, то размер результата будет равен размеру 2 списка.

**Описание решения**

Проходимся по двум спискам с помощью двух указателей. Начинаем с проверки, что интервалы пересекаются. Если условие выполняется, то берем этот интервал, где `start = max(a1, a2)` и `end = min(b1, b2)`. Далее смещаем указатели, ориентируясь на `end` текущих интервалов. Цикл будет продолжаться до тех пор, пока любой из указателей не выйдет за границу массива.