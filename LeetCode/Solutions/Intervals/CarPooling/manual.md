## Success

### Вариант 1

```csharp
public class Solution
{
    public bool CarPooling(int[][] trips, int capacity)
    {
        var tripsList = new List<int[]>();
        foreach (var trip in trips)
        {
            var passengers = trip[0];
            
            if (passengers > capacity)
                return false;
                
            tripsList.Add([trip[1], passengers]);
            tripsList.Add([trip[2], -passengers]);
        }
        
        tripsList.Sort((a, b) => 
        {
            if (a[0] == b[0])
                return a[1].CompareTo(b[1]);
                
            return a[0].CompareTo(b[0]);     
        });
        
        var currPassengers = 0;
        foreach (var trip in tripsList)
        {
            currPassengers += trip[1];
            if (currPassengers > capacity)
                return false;
        }
        
        return true;
    }
}
```

***Оценка по времени:*** O(n log n)

***Оценка по памяти:*** O(n)

**Описание решения**

Заполняем список `tripsList`, превращая `trips` в одномерный массив с точкой и числом пассажиров, которое для начальной точки являются положительным числом, а для конечной точки - отрицательным. Далее производим сортировку по возрастанию. Если точки равны, то уже сортируем по числу пассажиров, чтобы сначала освободить машину, затем ее загрузить. Далее проходимся по массиву `tripsList` и прибавляем число пассажиров в переменной `currPassengers`. После прибавления сравниваем с `capacity`, чтобы число пассажиров не вышло за лимит.

### Вариант 2 (оптимальное решение)

```csharp
public class Solution
{
    public bool CarPooling(int[][] trips, int capacity)
    {
        var tripsCountSort = new int[1001];
        foreach (var trip in trips)
        {
            var passengers = trip[0];
            tripsCountSort[trip[1]] += passengers;
            tripsCountSort[trip[2]] -= passengers;
        }

        var currPassengers = 0;
        foreach (var trip in tripsCountSort)
        {
            currPassengers += trip;
            if (currPassengers > capacity)
                return false;
        }
        
        return true;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(1)

**Описание решения**

То же самое решение, но используется постоянное пространство за счет `CountSort`, так как есть условие `0 <= from < to <= 1000`.