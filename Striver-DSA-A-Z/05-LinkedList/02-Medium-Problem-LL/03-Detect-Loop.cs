using Striver_DSA_A_Z._04_LinkedList._1d_Linked_List;

namespace Striver_DSA_A_Z._04_LinkedList._02_Medium_Problem_LL;

public partial class LinkedList {
    public bool HasCycle(ListNode head) {
        if(head ==null || head.next==null)
            return false;
        ListNode fast = head;
        ListNode slow = head;

        while(fast!=null)
        {


            slow = slow.next;
            fast = fast.next;
            if(fast!=null)
                fast = fast.next;
            if(slow == fast)
                return true;
        }
        return false;
    }
}