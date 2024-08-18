using Striver_DSA_A_Z._04_LinkedList._1d_Linked_List;

namespace Striver_DSA_A_Z._04_LinkedList._02_Medium_Problem_LL;

public partial class LinkedList
{
    public ListNode ReverseList(ListNode head)
    {

        if (head == null || head.next == null)
            return head;
        ListNode current = head.next;
        ListNode prev = head;
        ListNode secondPrev = null;

        while (current != null)
        {
            prev.next = secondPrev;
            secondPrev = prev;
            prev = current;
            current = current.next;
        }
        prev.next = secondPrev;
        return prev;

    }
}