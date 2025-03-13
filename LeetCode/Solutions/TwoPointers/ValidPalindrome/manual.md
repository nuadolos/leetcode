## Success

### Вариант 1 (универсальный)

```csharp
public class Solution
{
    public bool IsPalindrome(string s)
    {
        int left = 0, right = s.Length - 1;
        while (left < right)
        {
            if (!char.IsLetterOrDigit(s[left]))
                left++;
            else if (!char.IsLetterOrDigit(s[right]))
                right--;
            else if (char.ToLower(s[left++]) != char.ToLower(s[right--]))
                return false; 
        }
        
        return true;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(1)

**Описание решения**

Используем два указателя с двух сторон. Проходимся по строке, исключая все символы, кроме цифр и букв, а также сравнивая два элемента слева и справа в нижнем регистре. **Палиндромом** является строка, в данном случае, которая будет равна сама себе в перевернутом виде. 

### Вариант 2 (только символы ASCII)

```csharp
public class Solution
{
    public bool IsPalindrome(string s)
    {
        int left = 0, right = s.Length - 1;
        while (left < right)
        {
            if (!IsLetterOrDigit(s[left]))
                left++;
            else if (!IsLetterOrDigit(s[right]))
                right--;
            else if (ToLower(s[left++]) != ToLower(s[right--]))
                return false; 
        }
        
        return true;
    }
    
    private static bool IsLetterOrDigit(char c) =>
        (c -'a' is >= 0 and <= 25) 
            || (c -'A' is >= 0 and <= 25) 
            || (c - '0' is >= 0 and <= 9);
    
    private static char ToLower(char c) =>
        c -'A' is >= 0 and <= 25
            ? (char)('a' + (c - 'A'))
            : c;
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(1)

**Описание решения**

Тоже самое решение, но используется ограниченное кол-во символов. Вместо универсального метода `char.ToLower` используется `ToLower`, вычисляющий ASCII-символ в нижнем регистре, и вместо универсального метода `char.IsLetterOrDigit` используется `IsLetterOrDigit`, вычисляющий является ли ASCII-символ буквой или цифрой.