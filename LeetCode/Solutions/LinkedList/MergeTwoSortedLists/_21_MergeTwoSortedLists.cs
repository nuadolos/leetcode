using LeetCode.Structures;

namespace LeetCode.Solutions.LinkedList.MergeTwoSortedLists;

public static class _21_MergeTwoSortedLists
{
    public static ListNode? Solution(ListNode? list1, ListNode? list2)
    {
        var dummy = new ListNode();
        var current = dummy;

        while (list1 != null || list2 != null)
        {
            if (list1 != null && (list2 == null || list1.val < list2.val))
            {
                current!.next = list1;
                list1 = list1.next;
            }
            else
            {
                current!.next = list2;
                list2 = list2!.next;
            }

            current = current.next;
        }

        return dummy.next;
    }
}

public static class _21_MergeTwoSortedListsTestCases
{
    public static (ListNode List1, ListNode List2) Test_1 { get; } = (new(1, new(2, new(4))), new(1, new(3, new(4))));
    public static (ListNode? List1, ListNode List2) Test_2 { get; } = (null, new(1));
}