namespace LeetCode.Solutions.Easy;

public static class _344_ReverseString
{
    public static void Solution(char[] s)
    {
        var firstIndex = 0;
        var lastIndex = s.Length - 1;

        while (firstIndex < lastIndex)
        {
            var temp = s[lastIndex];
            s[lastIndex--] = s[firstIndex];
            s[firstIndex++] = temp;
        }
    }
}
