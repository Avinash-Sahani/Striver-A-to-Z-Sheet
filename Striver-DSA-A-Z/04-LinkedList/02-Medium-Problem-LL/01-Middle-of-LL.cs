using Striver_DSA_A_Z._04_LinkedList._1d_Linked_List;

namespace Striver_DSA_A_Z._04_LinkedList._02_Medium_Problem_LL;

public partial class LinkedList
{
    public ListNode MiddleNode(ListNode head) {

        if(head ==null || head.next ==null)
            return head;
        ListNode current = head;
        ListNode prev = head;
        while(current.next!=null)
        {
            current = current.next;
            if(current.next!=null)
                current = current.next;
            prev = prev.next;
        }
        return prev;

    }
}