## Success

```csharp
public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int left = 0, right = nums.Length - 1, currentIndex = right;

        var result = new int[nums.Length];
        while (left <= right)
        {
            var leftValue = nums[left];
            var leftSquare = leftValue * leftValue;

            var rightValue = nums[right];
            var rightSquare = rightValue * rightValue;

            int value;
            if (leftSquare >= rightSquare)
            {
                value = leftSquare;
                left++;
            }
            else
            {
                value = rightSquare;
                right--;
            }

            result[currentIndex--] = value;
        }

        return result;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(n)

**Описание решения**

Используем два указателя с двух сторон и массив со значениями, возведенные в квадрат. Проходимся по *отсортированному по возрастанию* массиву и сравниваем два элемента в квадрате с начала и с конца. Далее записываем в конец результата больший из квадратов, смещая при этом указатель. Шаги повторяются, пока левый указатель не станет больше правого.