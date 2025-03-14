namespace LeetCode.Solutions.TwoPointers.IntersectionOfSortedArrays;

public static class _InterviewBit_IntersectionOfSortedArrays
{
    public static List<int> Solution(List<int> A, List<int> B)
    {
        int aPointer = 0, bPointer = 0;
        var result = new List<int>();
        while (aPointer < A.Count && bPointer < B.Count)
        {
            var aNum = A[aPointer++];
            var bNum = B[bPointer++];

            if (aNum == bNum)
                result.Add(aNum);
            else if (aNum > bNum)
                aPointer--;
            else
                bPointer--;
        }

        return result;
    }
}

public static class _InterviewBit_IntersectionOfSortedArraysTestCases
{
    public static (List<int> A, List<int> B) Test_1 { get; } = ([1, 2, 3, 3, 4, 5, 6], [3, 3, 5]);
    public static (List<int> A, List<int> B) Test_2 { get; } = ([1, 2, 3, 3, 4, 5, 6], [3, 5]);
}