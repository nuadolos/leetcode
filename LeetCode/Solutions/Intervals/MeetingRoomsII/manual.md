## Success

```csharp
public class Solution
{
    public int MinMeetingRooms(int[][] intervals)
    {
        if (intervals.Length < 2)
            return intervals.Length;

        var points = new List<int[]>();
        foreach (var interval in intervals)
        {
            points.Add([interval[0], 1]);
            points.Add([interval[1], -1]);
        }

        points.Sort((a, b) =>
        {
            if (a[0] == b[0])
                return a[1].CompareTo(b[1]);

            return a[0].CompareTo(b[0]);
        });

        int maxRooms = 0, currRooms = 0;
        foreach (var point in points)
        {
            currRooms += point[1];
            maxRooms = Math.Max(maxRooms, currRooms);
        }

        return maxRooms;
    }
}
```

***Оценка по времени:*** O(n log n)

***Оценка по памяти:*** O(n)

**Описание решения**

Изначально заполняем список `points`, который будет представлять из себя массив с точкой и пометкой, является ли данная точка началом отрезка (`1` - начало, `-1` - конец). Далее сортируем точки по возрастанию, а также дополнительно, если точки равны, сортируем по пометке, чтобы сначала комната осводилась, а потом ее заняли. Далее проходимся по массиву `points`, вычисляя максимально возможное количество нужных комнат.