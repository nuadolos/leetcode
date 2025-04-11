using System.Text;

namespace LeetCode.Solutions.Stack.MinimumRemoveToMakeValidParentheses;

public static class _1249_MinimumRemoveToMakeValidParentheses
{
    public static string Solution(string s)
    {
        var resultIndex = 0;
        var result = new StringBuilder();
        var stack = new Stack<int>();

        for (int i = 0; i < s.Length; i++)
        {
            var ch = s[i];
            if (ch is ')' && !stack.TryPop(out var _))
                continue;
            else if (ch is '(')
                stack.Push(resultIndex);

            result.Append(ch);
            resultIndex++;
        }

        while (stack.TryPop(out var index))
            result.Remove(index, 1);

        return result.ToString();
    }
}

public static class _1249_MinimumRemoveToMakeValidParenthesesTestCases
{
    public static string Test_1 { get; } = "lee(t(c)o)de)";
    public static string Test_2 { get; } = "))((";
}