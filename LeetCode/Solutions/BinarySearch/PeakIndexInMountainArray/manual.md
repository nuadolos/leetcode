## Success

```csharp
public class Solution
{
    public int PeakIndexInMountainArray(int[] arr)
    {
        static bool Good(int prev, int current) =>
            prev < current;

        int l = 1, r = arr.Length - 1;
        while (r - l > 1)
        {
            var m = (l + r) / 2;
            if (Good(arr[m - 1], arr[m]))
                l = m;
            else
                r = m;
        }

        return l;
    }
}
```

***Оценка по времени:*** O(log n)

***Оценка по памяти:*** O(1)

**Описание решения**

Инициализируем два указателя, но не начинаем с боков, так как индекс пика там не может быть. Проходимся бинарным поиском, определяя `Good` элемент по условию, что предыдущий элемент меньше, чем текущий. Таким образом, левый указатель будет на пике между возрастанием и убыванием.