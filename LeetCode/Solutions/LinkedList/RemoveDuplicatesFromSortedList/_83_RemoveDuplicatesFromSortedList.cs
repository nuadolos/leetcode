using LeetCode.Structures;

namespace LeetCode.Solutions.LinkedList.RemoveDuplicatesFromSortedList;

public static class _83_RemoveDuplicatesFromSortedList
{
    public static ListNode? Solution(ListNode? head)
    {
        ListNode? prev = head, current = head?.next;
        while (current != null)
        {
            if (prev!.val == current.val)
                prev.next = current.next;
            else
                prev = current;

            current = current.next;
        }

        return head;
    }
}

public static class _83_RemoveDuplicatesFromSortedListTestCases
{
    public static ListNode Test_1 { get; } = new(1, new(1, new(2, new(3, new(3)))));
    public static ListNode Test_2 { get; } = new(1, new(1, new(2)));
}