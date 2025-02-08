using System.Text;

namespace LeetCode.Solutions.Easy;

public static class _14_LongestCommonPrefix
{
    public static string Solution(string[] strs)
    {
        if (strs.Length == 1)
            return strs[0];

        var firstStr = strs[0];
        var result = string.Empty;

        for (int i = 0; i < firstStr.Length; i++)
        {
            var @char = firstStr[i];

            for (int j = 1; j < strs.Length; j++)
            {
                if (i >= strs[j].Length || @char != strs[j][i])
                    return result;
            }

            result += @char;
        }

        return result;
    }
}
