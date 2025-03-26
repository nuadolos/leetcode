namespace LeetCode.Solutions.SlidingWindow.MaximizeDistanceToClosestPerson;

public static class _849_MaximizeDistanceToClosestPerson
{
    public static int Solution(int[] seats)
    {
        int l = 0, r = 0, maxDistance = 0;
        while (l < seats.Length)
        {
            while (r + 1 < seats.Length && seats[r] == seats[r + 1])
                r++;

            if (seats[r] == 0)
            {
                var currentIndex = l == 0 || r == seats.Length - 1
                    ? r
                    : l + (r - l) / 2;

                maxDistance = Math.Max(maxDistance, currentIndex - l + 1);
            }

            l = ++r;
        }

        return maxDistance;
    }
}

public static class _849_MaximizeDistanceToClosestPersonTestCases
{
    public static int[] Test_1 { get; } = [1, 0, 0, 0, 1, 0, 1];
    public static int[] Test_2 { get; } = [0, 0, 0, 0, 1];
    public static int[] Test_3 { get; } = [1, 0, 0, 0, 0];
}