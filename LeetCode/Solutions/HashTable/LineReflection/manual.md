## Success

```csharp
public class Solution
{
    public bool IsReflected(int[][] points)
    {
        int minX = points[0][0], maxX = points[0][0];

        var hashSet = new HashSet<(int, int)>();
        foreach (var point in points)
        {
            var x = point[0];
            var y = point[1];

            if (minX > x)
                minX = x;
            else if (maxX < x)
                maxX = x;

            hashSet.Add((x, y));
        }

        var sumX = minX + maxX;
        foreach (var point in points)
        {
            if (!hashSet.Contains((sumX - point[0], point[1])))
                return false;
        }

        return true;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(n)

**Описание решения**

Предварительно заполняем хеш-таблицу, а также ищем для симметрии мин. и макс. значения X. Далее через формулу поиска симметричной точки X проверяем ее наличие в хеш-таблице. Если такой точки нет, то ось симметрии невозможно построить.