namespace LeetCode.Solutions.BinarySearch.PeakIndexInMountainArray;

public static class _852_PeakIndexInMountainArray
{
    public static int Solution(int[] arr)
    {
        static bool Good(int prev, int current) =>
            prev < current;

        int l = 1, r = arr.Length - 1;
        while (r - l > 1)
        {
            var m = (l + r) / 2;
            if (Good(arr[m - 1], arr[m]))
                l = m;
            else
                r = m;
        }

        return l;
    }
}

public static class _852_PeakIndexInMountainArrayTestCases
{
    public static int[] Test_1 { get; } = [0, 10, 5, 2];
    public static int[] Test_2 { get; } = [0, 1, 2, 3, 0];
}