namespace LeetCode.Solutions.SlidingWindow.StringCompression;

public static class _443_StringCompression
{
    public static int Solution(char[] chars)
    {
        int l = 0, r = 0, slow = 0;
        while (l < chars.Length)
        {
            while (r + 1 < chars.Length && chars[r] == chars[r + 1])
                r++;

            chars[slow++] = chars[l];

            if (l != r)
            {
                var count = r - l + 1;
                foreach (var c in count.ToString())
                    chars[slow++] = c;
            }

            l = ++r;
        }

        return slow;
    }
}

public static class _443_StringCompressionTestCases
{
    public static char[] Test_1 { get; } = ['a', 'a', 'b', 'b', 'c', 'c', 'c'];
    public static char[] Test_2 { get; } = ['a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b'];
}