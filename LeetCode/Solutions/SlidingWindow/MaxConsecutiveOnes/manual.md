## Success

```csharp
public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int left = 0, right = 0, maxSequence = 0;
        while (left < nums.Length)
        {
            while (right + 1 < nums.Length && nums[right] == nums[right + 1])
                right++;
                
            if (nums[right] == 1)
                maxSequence = Math.Max(maxSequence, right - left + 1);    
                
            left = ++right;        
        }
        
        return maxSequence;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(1)

**Описание решения**

Итерируемся по массиву относительно левого указателя. Далее ищем при вычислении правого указателя границу между `0` и `1`. Если элемент правого указателя равен `1`, значит закончилась последовательность единиц, иначе - последовательность нулей, которая нам не нужна. Введем также максимальную последовательность единиц и пересчитываем, если текущая последовательность оказалась больше. Далее передвигаем оба указателя на `right + 1`.