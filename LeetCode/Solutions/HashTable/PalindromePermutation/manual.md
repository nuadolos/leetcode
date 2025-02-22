## Success

```csharp
public class Solution
{
    public bool CanPermutePalindrome(string s)
    {
        var counter = new int[26];
        foreach (var letter in s)
            counter[letter - 'a']++;

        var oddCount = 0;
        foreach (var count in counter)
        {
            if (count % 2 == 1)
                oddCount++;
        }

        return oddCount < 2;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(1)

Так как используем ограниченное кол-во букв (26) - **англ. буквы + нижний регистр**.

**Описание решения**

Подсчитываем кол-во встречаемых букв в строке, затем считаем кол-во нечетных встречаемых букв. **Палиндромом** является строка, в которой каждая буква встречается четное кол-во раз или же только 1 буква нечетное кол-во раз.