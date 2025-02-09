using LeetCode.Solutions.Easy;
using LeetCode.Solutions.Medium;
using System.Diagnostics;

var timer = new Stopwatch();
timer.Start();

#region Easy

// easy
//_1089_DuplicateZeros.Solution([1, 0, 2, 3, 0, 4, 5, 0]);
//_88_MergeSortedArray.Solution([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
//_27_RemoveElement.Solution([0, 4, 4, 0, 4, 4, 4, 0, 2], 4);
//_26_RemoveDuplicatesFromSortedArray.Solution([0, 1, 1, 1, 2, 2, 3, 3, 4]);
//_1346_CheckIfNAndItsDoubleExist.Solution([3, 1, 7, 11]);
//_941_ValidMountainArray.Solution([0, 1, 2, 1]);
//_1299_ReplaceElementsWithGreatestElementOnRightSide.Solution([17, 18, 5, 4, 6, 1]);
//_283_MoveZeroes.Solution([0, 1, 0, 3, 12]);
//_905_SortArrayByParity.Solution([3, 1, 2, 4]);
//_1051_HeightChecker.Solution([5, 1, 2, 3, 4]);
//_414_ThirdMaximumNumber.Solution([2, 4, 4, 3, 4, 5]);
//_448_FindAllNumbersDisappearedInAnArray.Solution([4, 3, 2, 7, 8, 2, 3, 1]);
//_977_SquaresOfSortedArray.Solution([-4, -1, 0, 3, 10]);
//_724_FindPivotIndex.Solution([1, 7, 3, 6, 5, 6]);
//_1672_RichestCustomerWealth.Solution([[1, 2, 3], [3, 2, 1]]);
//_383_RansomNote.Solution("aa", "aab");
//_1295_FindNumberWithEvenNumberOfDigits.Solution([12, 345, 2, 6, 7896]);
//_118_PascalsTriangle.Solution(6);
//_67_AddBinary.Solution("1011", "1010");
//_28_FindIndexOfFirstOccurrenceInString.Solution("mississippi", "pi");
//_14_LongestCommonPrefix.Solution(["aaa", "aa", "aaaa"]);
//_344_ReverseString.Solution(['H', 'e', 'l', 'l', 'o']);

#endregion

#region Medium

// medium
//_498_DiagonalTraverse.Solution([[1,2,3],[4,5,6]]);
//_54_SpiralMatrix.Solution([[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12]]);
//_167_TwoSum2InputArrayIsSorted.Solution([3, 24, 50, 79, 88, 150, 345], 200);
//_209_MinimumSizeSubarraySum.Solution(11, [2, 4, 5, 7, 8, 9]);
//_189_RotateArray.Solution([1, 2, 3, 4, 5, 6, 7], 3);

#endregion

timer.Stop();
Console.WriteLine($"Время выполнения - {timer.ElapsedMilliseconds} мс");