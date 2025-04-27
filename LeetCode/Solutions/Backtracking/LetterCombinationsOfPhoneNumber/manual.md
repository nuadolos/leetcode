## Success

```csharp
public class Solution
{
    private static string[] DigitLetters { get; } =
    [
        string.Empty, string.Empty, "abc", "def",
        "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz",
    ];
    
    public IList<string> LetterCombinations(string digits)
    {
        var result = new List<string>();

        if (string.IsNullOrEmpty(digits))
            return result;

        var stringBuilder = new StringBuilder();
        Backtrack(0);
        return result;
        
        void Backtrack(int index)
        {
            if (index == digits.Length)
            {
                result.Add(stringBuilder.ToString());
                return;
            }
                
            var letters = DigitLetters[digits[index] - '0'];
            for (int i = 0; i < letters.Length; i++)
            {
                stringBuilder.Append(letters[i]);
                Backtrack(index + 1);
                stringBuilder.Length--;
            }    
        }
    }
}
```

***Оценка по времени:*** O(n * 4^n)

***Оценка по памяти:*** O(n * 4^n)

Где `n` - кол-во элементов в строке `digits`, `4^n` - число строк в ответе.

**Описание решения**

Инициализируем список результатов и строку для сборки результатов. Начинаем с первого элемента. Сразу проверяем, что индекс равен размеру строки `digits` (именно строки с размером `digits.Length` должны попадать в результат). Далее находим буквы, закрепленные за цифрой, и итерируемся по ним. Далее добавляем ее в строку и вызываем снова метод `Backtrack`, но уже смещая индекс на единицу. После выхода из метода удаляем конечный символ в строке, подставляя каждый новый символ в следующей итерации.