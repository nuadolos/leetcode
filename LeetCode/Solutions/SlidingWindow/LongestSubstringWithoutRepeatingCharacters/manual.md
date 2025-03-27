## Success

```csharp
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length < 2)
            return s.Length;
            
        var hashSet = new HashSet<char>();
        int l = 0, r = -1, maxLength = 0;
        while (l < s.Length)
        {
            while (r + 1 < s.Length && !hashSet.Contains(s[r + 1]))
                hashSet.Add(s[++r]);
                
            var length = r - l + 1;
            if (maxLength < length)
                maxLength = length;
                
            hashSet.Remove(s[l++]);        
        }    
        
        return maxLength;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(k)

Где k - число уникальных символов в строке `s`.

**Описание решения**

Итерируемся по массиву относительно левого указателя. Далее проверяем при вычислении правого указателя, есть ли уже в хеш-таблице следующий символ. Если нет, то увеличиваем правый указатель, иначе считаем, что нашли подстроку. Считаем длину этой подстроки и записываем в результат, если размер оказался больше предыдущего значения. В конце удаляем символ на левом указателе и увеличаваем его на единицу.