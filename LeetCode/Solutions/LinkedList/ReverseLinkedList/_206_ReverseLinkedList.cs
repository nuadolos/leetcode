using LeetCode.Structures;

namespace LeetCode.Solutions.LinkedList.ReverseLinkedList;

public static class _206_ReverseLinkedList
{
    public static ListNode? Solution(ListNode? head)
    {
        ListNode? prev = null;
        var current = head;
        while (current != null)
        {
            var tmp = current;
            current = current.next;
            tmp.next = prev;
            prev = tmp;
        }

        return prev;
    }
}

public static class _206_ReverseLinkedListTestCases
{
    public static ListNode Test_1 { get; } = new ListNode(1, new(2, new(3, new(4, new(5)))));
    public static ListNode Test_2 { get; } = new ListNode(1, new(2));
}