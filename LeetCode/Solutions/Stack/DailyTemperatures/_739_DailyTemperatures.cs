namespace LeetCode.Solutions.Stack.DailyTemperatures;

public static class _739_DailyTemperatures
{
    public static int[] Solution(int[] temperatures)
    {
        var result = new int[temperatures.Length];
        var stack = new Stack<int>();

        for (int i = 0; i < temperatures.Length; i++)
        {
            while (stack.Count > 0
                && temperatures[stack.Peek()] < temperatures[i])
            {
                var lastTIndex = stack.Pop();
                result[lastTIndex] = i - lastTIndex;
            }

            stack.Push(i);
        }

        return result;
    }
}

public static class _739_DailyTemperaturesTestCases
{
    public static int[] Test_1 { get; } = [73, 74, 75, 71, 69, 72, 76, 73];
    public static int[] Test_2 { get; } = [30, 40, 50, 60];
}