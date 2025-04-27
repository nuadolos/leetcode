using System.Text;

namespace LeetCode.Solutions.Backtracking.GenerateParentheses;

public static class _22_GenerateParentheses
{
    public static IList<string> Solution(int n)
    {
        var result = new List<string>();
        var sb = new StringBuilder();
        Backtrack(0, 0);
        return result;

        void Backtrack(int open, int close)
        {
            if (n * 2 == sb.Length)
            {
                result.Add(sb.ToString());
                return;
            }

            if (open < n)
            {
                sb.Append('(');
                Backtrack(open + 1, close);
                sb.Length--;
            }

            if (close < open)
            {
                sb.Append(')');
                Backtrack(open, close + 1);
                sb.Length--;
            }
        }
    }
}

public static class _22_GenerateParenthesesTestCases
{
    public static int Test_1 { get; } = 2;
    public static int Test_2 { get; } = 3;
}