## Success

```csharp
public class Solution
{
    public bool BackspaceCompare(string s, string t)
    {
        int sIndex = s.Length, tIndex = t.Length;
        while (sIndex > -1 && tIndex > -1)
        {
            sIndex = FindIndexAfterSkippingBackspaces(s, sIndex - 1);
            tIndex = FindIndexAfterSkippingBackspaces(t, tIndex - 1);

            if (sIndex >= 0 && tIndex >= 0 && s[sIndex] != t[tIndex])
                return false;
        }

        return sIndex == tIndex;
    }

    private static int FindIndexAfterSkippingBackspaces(string s, int currentIndex)
    {
        var skipCouint = 0;
        while (currentIndex >= 0)
        {
            var isSharp = s[currentIndex] == '#';
            if (skipCouint == 0 && !isSharp)
                break;

            if (s[currentIndex] == '#')
                skipCouint++;
            else
                skipCouint--;

            currentIndex--;
        }

        return currentIndex;
    }
}
```

***Оценка по времени:*** O(n + m)

***Оценка по памяти:*** O(1)

**Описание решения**

Используем два указателя **каждому по указателю**. Далее с каждым шагом ищем индексы элементов, которые не будет пропущены (если перед элементом есть `#`, то такой элемент необходимо пропускать). Если при сравнении элементы на текущих индексах не равны, то результатом будет `false`. Если по окончанию сравнения элементов и пропуска элементов индексы равны `-1` и `-1`, тогда ответом будет `true`.