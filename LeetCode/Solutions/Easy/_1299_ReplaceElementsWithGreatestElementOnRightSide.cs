namespace LeetCode.Solutions.Easy;

public static class _1299_ReplaceElementsWithGreatestElementOnRightSide
{
    public static int[] Solution(int[] arr)
    {
        if (arr.Length == 0)
            return arr;

        var rightMaxEl = -1;

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            var tmpMax = Math.Max(arr[i], rightMaxEl);
            arr[i] = rightMaxEl;
            rightMaxEl = tmpMax;
        }

        return arr;
    }
}
