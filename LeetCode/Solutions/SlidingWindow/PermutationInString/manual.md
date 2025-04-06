## Success

### Вариант 1

```csharp
public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s2.Length < s1.Length)
            return false;
            
        var s1Counter = new int[26];
        foreach (var c in s1)
            s1Counter[c - 'a']++;
            
        var s2Counter = new int[26];    
        int l = 0, r = -1;
        while (l + s1.Length <= s2.Length)
        {
            while (r + 1 < s2.Length && r + 1 < l + s1.Length)
                s2Counter[s2[++r] - 'a']++;
                
            if (IsMatch(s1Counter, s2Counter))
                return true;
                
            s2Counter[s2[l++] - 'a']--;       
        }
        
        return false;
    }
    
    private static bool IsMatch(int[] s1Counter, int[] s2Counter)
    {
        for (int i = 0; i < s1Counter.Length; i++)
        {
            if (s1Counter[i] != s2Counter[i])
                return false;
        }
        
        return true;
    }
}
```

***Оценка по времени:*** O(n + k)

Где n - размер строки s1, k - размер строки s2.

***Оценка по памяти:*** O(1)

**Описание решения**

Тут работа с анаграммами, поэтому используем счетчики. Заполняем предварительно счетчик `s1`, то есть подстроку, которую будем искать. Далее двигаемся через плавающее окно и проверяем, что правый указатель не вышел за рамки `l + s1.Length`, а также добавляем в счетчик `s2` элементы. Далее через метод `IsMatch` сравниваем два массива счетчиков. Если по итогу массивы равны, тогда ответ `true`, иначе - уменьшаем счетчик `s2` элемента левого указателя и смещаем левый указатель.

### Вариант 2 (оптимальное решение)

```csharp
public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s2.Length < s1.Length)
            return false;
            
        var s1Counter = new int[26];
        foreach (var c in s1)
            s1Counter[c - 'a']++;
            
        var s2Counter = new int[26];    
        int l = 0, r = -1;
        while (l < s2.Length)
        {
            while (r + 1 < s2.Length)
            {
                var cIndex = s2[r + 1] - 'a';
                if (s2Counter[cIndex] + 1 > s1Counter[cIndex])
                    break;
                    
                s2Counter[s2[++r] - 'a']++;    
            }
                
            if (r - l + 1 == s1.Length)
                return true;
                
            s2Counter[s2[l++] - 'a']--;       
        }
        
        return false;
    }
}
```

***Оценка по времени:*** O(n + k)

***Оценка по памяти:*** O(1)

**Описание решения**

Почти как первое решение, но здесь проверяем, что следующий элемент уже есть в счетчике `s1`. Если элемента нет, то уменьшаем его (зн-ие `-1` возможно для счетчика `s2`). Таким образом, смещается левый указатель, а правый будет его догонять, поэтому уже тот же элемент на правом указателе выдаст `-1 (из счетчика s2) + 1 <= 0 (из счетчика s1)`. Также ответ рассчитывается из размера окна, который сравнивается с размером строки `s1`. 