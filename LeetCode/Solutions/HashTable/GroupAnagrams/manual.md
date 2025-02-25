## Success

```csharp
public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var groupDictionary = new Dictionary<string, IList<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            var str = strs[i];
            var counter = new char[26];

            for (int j = 0; j < str.Length; j++)
                counter[str[j] - 'a']++;

            var key = new string(counter);

            if (groupDictionary.TryGetValue(key, out var list))
                list.Add(str);
            else
                groupDictionary[key] = [str];
        }

        return new List<IList<string>>(groupDictionary.Values);
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(1)

Используется известное для нас число при инициализации вспомогательного массива `counter`, так как строки `s` и `t` содержат только *англ. символы в нижнем регистре*.

**Описание решения**

**Анаграммой** считается строка, которая при перестановке символов получает вторую строку. Таким образом, строки должны быть одинаковых размеров. Далее используем общий счетчик, который при символах из строки `s` будем увеличивать, а при символах из строки `t` будем уменьшать. Если же где-то присутствуют символ, которого нет в другой строке, то есть счетчик **не будет равным 0**, значит строка `t` не является *анаграммой* строки `s`.