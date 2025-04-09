namespace LeetCode.Solutions.Stack.ValidParentheses;

public static class _20_ValidParentheses
{
    public static bool Solution(string s)
    {
        var stack = new Stack<char>();

        foreach (var ch in s)
        {
            if (ch is '(' or '{' or '[')
            {
                stack.Push(ch switch
                {
                    '(' => ')',
                    '{' => '}',
                    _ => ']'
                });

                continue;
            }

            if (stack.Count == 0)
                return false;

            var lastChar = stack.Pop();
            if (lastChar != ch)
                return false;
        }

        return stack.Count == 0;
    }
}

public static class _20_ValidParenthesesTestCases
{
    public static string Test_1 { get; } = "()[{}()]";
    public static string Test_2 { get; } = "(()}";
}