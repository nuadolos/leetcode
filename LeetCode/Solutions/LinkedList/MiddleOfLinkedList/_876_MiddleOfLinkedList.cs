using LeetCode.Structures;

namespace LeetCode.Solutions.LinkedList.MiddleOfLinkedList;

public static class _876_MiddleOfLinkedList
{
    public static ListNode Solution(ListNode head)
    {
        var slow = head;
        var fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow!.next;
            fast = fast.next.next;
        }

        return slow!;
    }
}

public static class _876_MiddleOfLinkedListTestCases
{
    public static ListNode Test_1 { get; } = new ListNode(1, new(2, new(3, new(4, new(5)))));
    public static ListNode Test_2 { get; } = new ListNode(1, new(2, new(3, new(4))));
}