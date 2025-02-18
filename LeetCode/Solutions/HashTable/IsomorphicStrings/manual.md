## Success

### Вариант 1

```csharp
public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        var sDictionary = new Dictionary<char, char>();
        var tDictionary = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (sDictionary.TryGetValue(s[i], out char tChar) && t[i] != tChar)
                return false;

            if (tDictionary.TryGetValue(t[i], out char sChar) && s[i] != sChar)
                return false;

            sDictionary[s[i]] = t[i];
            tDictionary[t[i]] = s[i];
        }

        return true;
    }
}
```

***Оценка по времени:*** O(n)

Где n - размер строки. В данном случае размеры строк `s` и `t` равны.

***Оценка по памяти:*** O(k)

Вообще можно оценить, как `O(k)`, где k - кол-во различных символов, встречаемых в строках `s` и `t`. Но в данном случае строки ограничены **символами ASCII**.

**Описание решения**

Инициализируем две хеш-таблицы, которые будут содержать символы своих строк (key) и символы, к котороым они замаппились (value). Если символы отсутствуют в хеш-таблицах, то мы их добавляем. Если же встретились, то проверяем, стоит ли на текущей позиции замаппленный ранее символ или нет. Если не тот, то результатом будет `false`. Если весь цикл обошли, значит строки являются *изоморфными*.

### Вариант 2 (оптимальное решение)

```csharp
public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        var sMap = new Dictionary<char, int>();
        var tMap = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            var sChar = s[i];
            var tChar = t[i];

            if (!sMap.TryGetValue(sChar, out var sIndex))
            {
                sMap[sChar] = i;
                sIndex = i;
            }

            if (!tMap.TryGetValue(tChar, out var tIndex))
            {
                tMap[tChar] = i;
                tIndex = i;
            }

            if (sIndex != tIndex)
                return false;
        }

        return true;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(k)

**Описание решения**

Инициализируем две хеш-таблицы, которые будут содержать символы своих строк (key) и индексы в строке, на которых они нашлись (value). Если символы отсутствуют в хеш-таблицах, то мы их добавляем. Если же встретились, то проверяем, совпадают ли их изначальные индексы или нет. Например, при **paper** и **title** в хеш-таблице на третьей итерации будут возвращены `0` и `0`, что означает их совпадение. При **bubu** и **vova** в хеш-таблице на четвертой итерации будут возвращены `1` и `3`, так как символ `a` отсутствовал в хеш-таблице и не соответсвовал символу `u`, потому что ранее мы смаппили их как `u` и `o`. Если весь цикл обошли, значит строки являются *изоморфными*.