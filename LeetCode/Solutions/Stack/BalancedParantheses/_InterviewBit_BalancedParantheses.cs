namespace LeetCode.Solutions.Stack.BalancedParantheses;

public static class _InterviewBit_BalancedParantheses
{
    public static int Solution(string A)
    {
        var balance = 0;

        foreach (var parenthesis in A)
        {
            balance += parenthesis == '(' ? 1 : -1;
            if (balance < 0)
                break;
        }

        return balance == 0 ? 1 : 0;
    }
}

public static class _InterviewBit_BalancedParanthesesTestCases
{
    public static string Test_1 { get; } = "(()())";
    public static string Test_2 { get; } = "))((()(())";
}