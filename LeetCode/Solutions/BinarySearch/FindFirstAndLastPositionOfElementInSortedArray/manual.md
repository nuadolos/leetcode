## Success

```csharp
public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int[] result = [-1, -1];
        if (nums.Length == 0)
            return result;
        
        result[0] = SearchStartPosition(nums, target);
        if (result[0] != -1)
            result[1] = SearchEndPosition(nums, target);
        
        return result;
    }
    
    private static int SearchStartPosition(int[] nums, int target)
    {
        bool Good(int num) =>
            num < target;
            
        int l = -1, r = nums.Length - 1;
        while (r - l > 1)
        {
            int m = (l + r) / 2;
            if (Good(nums[m]))
                l = m;
            else
                r = m;    
        }
        
        return nums[r] == target ? r : -1;
    }
    
    private static int SearchEndPosition(int[] nums, int target)
    {
        bool Good(int num) =>
            num <= target;
            
        int l = 0, r = nums.Length;
        while (r - l > 1)
        {
            int m = (l + r) / 2;
            if (Good(nums[m]))
                l = m;
            else
                r = m;    
        }
        
        return nums[l] == target ? l : -1;
    }
}
```

***Оценка по времени:*** O(log n)

***Оценка по памяти:*** O(1)

**Описание решения**

Проходимся по 1 бинарному поиску, где важным для нас является правый указатель, потому что мы хотим найти самый левый `target`, поэтому ставим левый указатель на `-1`, а правый указатель - `nums.Length - 1`. Если `target` был не найден в массиве, то 2 бинарный поиск пропускается. Иначе проходимся по 2 бинарному поиску, но уже противоположно условию 1 бинарного поиска, а именно важным является левый указатель, потому что хотим найти самый правый `target`, поэтому ставим левый указатель на `0`, а правый указатель - `nums.Length`.