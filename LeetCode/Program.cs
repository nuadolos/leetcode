﻿using LeetCode.RetryList;
using LeetCode.Solutions.Array;
using LeetCode.Solutions.Backtracking;
using LeetCode.Solutions.BinarySearch;
using LeetCode.Solutions.BinaryTree;
using LeetCode.Solutions.Easy;
using LeetCode.Solutions.Graphs;
using LeetCode.Solutions.HashTable;
using LeetCode.Solutions.Intervals;
using LeetCode.Solutions.LinkedList;
using LeetCode.Solutions.Medium;
using LeetCode.Solutions.SlidingWindow;
using LeetCode.Solutions.Stack;
using LeetCode.Solutions.TwoPointers;
using System.Diagnostics;

var timer = new Stopwatch();
timer.Start();

//BinaryTreeSolutions.Run();
//HashTableSolutions.Run();
//ArraySolutions.Run();
//TwoPointersSolutions.Run();
//SlidingWindowSolutions.Run();
//BinarySearchSolutions.Run();
//LinkedListSolutions.Run();
//StackSolutions.Run();
//IntervalsSolutions.Run();
//GraphsSolutions.Run();
//BacktrackingSolutions.Run();
//RetryListSolutions.Run();

#region Easy

// easy
//_1089_DuplicateZeros.Solution([1, 0, 2, 3, 0, 4, 5, 0]);
//_88_MergeSortedArray.Solution([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
//_27_RemoveElement.Solution([0, 4, 4, 0, 4, 4, 4, 0, 2], 4);
//_26_RemoveDuplicatesFromSortedArray.Solution([0, 1, 1, 1, 2, 2, 3, 3, 4]);
//_1346_CheckIfNAndItsDoubleExist.Solution([3, 1, 7, 11]);
//_941_ValidMountainArray.Solution([0, 1, 2, 1]);
//_1299_ReplaceElementsWithGreatestElementOnRightSide.Solution([17, 18, 5, 4, 6, 1]);
//_905_SortArrayByParity.Solution([3, 1, 2, 4]);
//_1051_HeightChecker.Solution([5, 1, 2, 3, 4]);
//_414_ThirdMaximumNumber.Solution([2, 4, 4, 3, 4, 5]);
//_448_FindAllNumbersDisappearedInAnArray.Solution([4, 3, 2, 7, 8, 2, 3, 1]);
//_1672_RichestCustomerWealth.Solution([[1, 2, 3], [3, 2, 1]]);
//_383_RansomNote.Solution("aa", "aab");
//_1295_FindNumberWithEvenNumberOfDigits.Solution([12, 345, 2, 6, 7896]);
//_118_PascalsTriangle.Solution(6);
//_67_AddBinary.Solution("1011", "1010");
//_28_FindIndexOfFirstOccurrenceInString.Solution("mississippi", "pi");
//_344_ReverseString.Solution(['H', 'e', 'l', 'l', 'o']);
//_119_PascalsTriangle2.Solution(3);
//_557_ReverseWordsInString3.Solution("Let's take LeetCode contest");
//_705_DesignHashSet.Solution();
//_706_DesignHashMap.Solution();
//_217_ContainsDuplicate.Solution([1, 4, 3, 2]);
//_136_SingleNumber.Solution([4, 1, 2, 1, 2]);
//_349_IntersectionOfTwoArrays.Solution([1, 2, 2, 1], [2, 2]);
//_202_HappyNumber.Solution(19);

#endregion

#region Medium

// medium
//_498_DiagonalTraverse.Solution([[1,2,3],[4,5,6]]);
//_54_SpiralMatrix.Solution([[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12]]);
//_209_MinimumSizeSubarraySum.Solution(11, [2, 4, 5, 7, 8, 9]);
//_151_ReverseWordsInString.Solution("the sky is blue");

#endregion

timer.Stop();
Console.WriteLine($"Время выполнения - {timer.ElapsedMilliseconds} мс");