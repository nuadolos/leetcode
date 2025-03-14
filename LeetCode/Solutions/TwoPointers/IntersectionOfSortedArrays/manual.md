## Success

```csharp
class Solution
{
    public List<int> intersect(List<int> A, List<int> B)
    {
        int aPointer = 0, bPointer = 0;
        var result = new List<int>();
        while (aPointer < A.Count && bPointer < B.Count)
        {
            var aNum = A[aPointer++];
            var bNum = B[bPointer++];

            if (aNum == bNum)
                result.Add(aNum);
            else if (aNum > bNum)
                aPointer--;
            else
                bPointer--;
        }

        return result;
    }
}
```

***Оценка по времени:*** O(n + m)

***Оценка по памяти:*** O(Min(n, m))

**Описание решения**

Используем два указателя **каждому по указателю**, так как оба массива **отсортированы по возрастанию**. Далее ищем пересечения. Если же число из массива `A` больше числа из `B`, значит двигаем указатель массива `B`, иначе - указатель массива `A`. Если числа равны, то сохраняем число в результате и двигаем оба указателя, так как теперь оба элемента не могут участвовать в пересечении.