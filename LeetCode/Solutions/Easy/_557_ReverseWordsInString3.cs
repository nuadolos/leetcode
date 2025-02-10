namespace LeetCode.Solutions.Easy;

public static class _557_ReverseWordsInString3
{
    public static string Solution(string s)
    {
        var left = 0;
        var right = 0;
        var chars = s.ToCharArray();

        while (right < chars.Length)
        {
            while (right < chars.Length && chars[right] != ' ')
                right++;

            Reverse(chars, left, right - 1);

            left = right + 1;
            right = left;
        }

        return new string(chars);
    }

    private static void Reverse(char[] chars, int left, int right)
    {
        while (left < right)
        {
            (chars[left], chars[right]) = (chars[right], chars[left]);
            left++;
            right--;
        }
    }
}
