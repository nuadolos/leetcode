using System.Text;

namespace LeetCode.Solutions.Medium;

public static class _151_ReverseWordsInString
{
    public static string Solution(string s)
    {
        return string.Join(
            separator: ' ',
            values: s
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Reverse());
    }
}
