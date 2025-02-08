namespace LeetCode.Solutions.Easy;

public static class _383_RansomNote
{
    public static bool Solution(string ransomNote, string magazine)
    {
        // Всего букв в английском - 26 (+ мы ограничиваемся нижним регистром)
        // Буквы имеют коды в диапазоне от 97 ('a') до 122 ('z')
        var letters = new int[26];

        foreach (var @char in magazine)
        {
            letters[@char - 'a']++;
        }

        foreach (var @char in ransomNote)
        {
            var charIndex = @char - 'a';

            letters[charIndex]--;

            if (letters[charIndex] == -1)
                return false;
        }

        return true;
    }
}
