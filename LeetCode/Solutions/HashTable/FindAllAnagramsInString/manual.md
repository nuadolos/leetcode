## Success

```csharp
public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        if (s.Length < p.Length)
            return [];

        var sCounter = new int[26];
        var pCounter = new int[26];

        for (int i = 0; i < p.Length; i++)
        {
            sCounter[s[i] - 'a']++;
            pCounter[p[i] - 'a']++;
        }

        var result = new List<int>();
        for (int i = 0; i < s.Length - p.Length; i++)
        {
            if (IsAnagram(sCounter, pCounter))
                result.Add(i);

            sCounter[s[i] - 'a']--;
            sCounter[s[i + p.Length] - 'a']++;
        }

        if (IsAnagram(sCounter, pCounter))
            result.Add(s.Length - p.Length);

        return result;
    }

    private static bool IsAnagram(int[] sCounter, int[] pCounter)
    {
        for (int i = 0; i < sCounter.Length; i++)
        {
            if (sCounter[i] != pCounter[i])
                return false;
        }

        return true;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(1)

Т.к. используем массимы одного размера (26 символов - **англ. буквы в нижнем регистре**)

**Описание решения**

Создаем два счетчика - для строк `s` и `p`. Заполняем их до размера строки `p`, затем начинаем проверку на анаграмму. В данном случае **анаграмма** определяется по счетчику, то есть те же символы должны иметь то же самое количество в двух массивах. Далее из счетчика строки `s` убираем символ, на котором находится текущий индекс, и прибавляем следующий символ, находящийся через размер строки `p` от текущего индекса. Так как последний индекс выдал бы исключение, будь он в цикле, он также проверяется и в случае совпадения его индекс записывается в результатный список.