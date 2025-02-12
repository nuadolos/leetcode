using System.Collections;

namespace LeetCode.Solutions.Easy;

public static class _349_IntersectionOfTwoArrays
{
    public static int[] Solution(int[] nums1, int[] nums2)
    {
        var result = new List<int>();
        var count = new BitArray(1001);

        foreach (var num in nums1)
        {
            count[num] = true;
        }

        foreach (var num in nums2)
        {
            if (!count[num])
                continue;

            count[num] = false;
            result.Add(num);
        }

        return [.. result];
    }
}
