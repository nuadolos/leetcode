namespace LeetCode.Solutions.Stack.EvaluateReversePolishNotation;

public static class _150_EvaluateReversePolishNotation
{
    public static int Solution(string[] tokens)
    {
        var stack = new Stack<int>();

        foreach (var token in tokens)
        {
            if (int.TryParse(token, out var num))
            {
                stack.Push(num);
                continue;
            }

            var secondOperand = stack.Pop();
            var firstOperand = stack.Pop();

            var operationResult = token switch
            {
                "+" => firstOperand + secondOperand,
                "-" => firstOperand - secondOperand,
                "*" => firstOperand * secondOperand,
                _ => firstOperand / secondOperand
            };

            stack.Push(operationResult);
        }

        return stack.Pop();
    }
}

public static class _150_EvaluateReversePolishNotationTestCases
{
    public static string[] Test_1 { get; } = ["2", "1", "+", "3", "*"];
    public static string[] Test_2 { get; } = ["4", "13", "5", "/", "+"];
}