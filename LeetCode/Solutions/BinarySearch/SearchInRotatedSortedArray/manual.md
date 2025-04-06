## Success

```csharp
public class Solution
{
    public int Search(int[] nums, int target)
    {
        bool Good(int num) =>
            num <= target;
        
        var offset = FindOffset(nums);
            
        int n = nums.Length;    
        int l = offset, r = nums.Length + offset;
        while (r - l > 1)
        {
            int m = (l + r) / 2;
            
            if (Good(nums[m % n]))
                l = m;
            else
                r = m;
        }
        
        var realLeft = l % n;
        return nums[realLeft] == target ? realLeft : -1;
    }
    
    private static int FindOffset(int[] nums)
    {
        bool Good(int num) =>
            num > nums[^1];
            
        int l = -1, r = nums.Length - 1;
        while (r - l > 1)
        {
            int m = (l + r) / 2;
            
            if (Good(nums[m]))
                l = m;
            else
                r = m;    
        }
        
        return r;
    }
}
```

***Оценка по времени:*** O(log n)

***Оценка по памяти:*** O(1)

**Описание решения**

Сначала находим оффсет сдвига, для этого сравниваем бинарным поиском число с последним элементом в массиве. Таким образом, найдется два указателя, где заканчивается возрастание (левый указатель) и, наоборот, начинается (правый указатель). Как раз правый указатель и будет оффсетом. Далее уже с этим оффсетом представляем наш отсортированный массив, но чтобы получить реальное число из массива, не получив оишбку, что мы вышли за границы, будем использовать `%` для получения остатка от деления на размер массива. Таким образом, получим реальный индекс числа в массиве. В конце рассчитываем реальный левый указатель и сравниваем с `target`.