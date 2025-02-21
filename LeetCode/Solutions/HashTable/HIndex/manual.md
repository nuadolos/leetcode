## Success

```csharp
public class Solution
{
    public int HIndex(int[] citations)
    {
        var n = citations.Length;
        var counter = new int[n + 1];
        foreach (int num in citations)
        {
            var actIndex = num > n ? n : num;
            counter[actIndex]++;
        }

        var total = 0;
        for (int h = counter.Length - 1; h >= 0; h--)
        {
            total += counter[h];
            if (total >= h)
                return h;
        }

        return 0;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(n)

**Описание решения**

Введем счетчик для всех значений в массиве `citations`. Те значения, которые больше массива, мы сохраняем в элементе с индексом `n == citations.Length`, так как `h` не может быть больше, чем элементов в массиве `citations`. Следующим шагом начинаем подсчет всех значений, а точнее их количество. И если `h` в каком-то моменте становится меньше или равен глобальному счетчику `total`, то мы нашли **индекс Хирша**.