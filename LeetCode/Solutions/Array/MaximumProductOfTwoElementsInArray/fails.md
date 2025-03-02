## Fails

1. Невнимательность - рассмотрел лишь один вариант, когда максимальное число ищется, если только одна переменная (`max2`) больше, чем `num`.

```csharp
public class Solution
{
    public int Solution(int[] nums)
    {
        int max1 = 0, max2 = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (max2 <= num)
                (max1, max2) = (max2, num);
        }

        return (max1 - 1) * (max2 - 1);
    }
}
```