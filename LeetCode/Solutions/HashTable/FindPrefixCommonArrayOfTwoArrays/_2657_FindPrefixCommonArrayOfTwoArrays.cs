using System.Numerics;

namespace LeetCode.Solutions.HashTable.FindPrefixCommonArrayOfTwoArrays;

public static class _2657_FindPrefixCommonArrayOfTwoArrays
{
    public static int[] Solution(int[] A, int[] B)
    {
        var result = new int[A.Length];
        ulong maskA = 0, maskB = 0;

        for (int i = 0; i < result.Length; i++)
        {
            maskA |= 1ul << A[i];
            maskB |= 1ul << B[i];
            result[i] = BitOperations.PopCount(maskA & maskB);
        }

        return result;
    }
}

public static class _2657_FindPrefixCommonArrayOfTwoArraysTestCases
{
    public static (int[] A, int[] B) Test_1 { get; } = ([1, 3, 2, 4], [3, 1, 2, 4]);
    public static (int[] A, int[] B) Test_2 { get; } = ([2, 3, 1], [3, 1, 2]);
}