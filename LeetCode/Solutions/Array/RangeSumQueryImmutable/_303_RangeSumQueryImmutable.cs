using static LeetCode.Solutions.Array.RangeSumQueryImmutable._303_RangeSumQueryImmutable;

namespace LeetCode.Solutions.Array.RangeSumQueryImmutable;

public static class _303_RangeSumQueryImmutable
{
    public static void Solution(string[] func, int[][] args)
    {
        NumArray? numArray = null;

        for (int i = 0; i < func.Length; i++)
        {
            var functionName = func[i];
            var arg = args[i];

            if (functionName == nameof(NumArray))
            {
                numArray = new NumArray(arg);
            }
            else if (functionName == nameof(NumArray.SumRange))
            {
                if (numArray == null)
                    throw new InvalidCastException($"{nameof(numArray)} is not initialized");

                if (arg.Length != 2)
                    throw new InvalidOperationException($"{nameof(arg)} must be of size 2 elements");

                numArray.SumRange(arg[0], arg[1]);
            }
        }
    }

    public class NumArray
    {
        private readonly int[] _prefixNums;

        public NumArray(int[] nums)
        {
            _prefixNums = new int[nums.Length + 1];

            var sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                _prefixNums[i + 1] = sum;
            }

        }

        public int SumRange(int left, int right)
        {
            return _prefixNums[right + 1] - _prefixNums[left];
        }
    }
}

public static class _303_RangeSumQueryImmutableTestCases
{
    public static (string[] Func, int[][] Args) Test_1 { get; } =
    (
        Func: [nameof(NumArray), nameof(NumArray.SumRange), nameof(NumArray.SumRange), nameof(NumArray.SumRange)],
        Args: [[-2, 0, 3, -5, 2, -1], [0, 2], [2, 5], [0, 5]]
    );
}