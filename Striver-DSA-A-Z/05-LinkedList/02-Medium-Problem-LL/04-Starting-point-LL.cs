namespace Striver_DSA_A_Z._04_LinkedList._02_Medium_Problem_LL;

public partial class LinkedList
{
    public ListNode DetectCycle(ListNode head) {

        if(head ==null || head.next==null)
            return null;
        ListNode fast = head;
        ListNode slow = head;
        int index = 0;
        while(fast!=null)
        {

            fast = fast?.next?.next;
            slow = slow.next;
            if(slow == fast)
                break;
        }
        if(fast==null)
            return null;
        slow = head;

        while(slow!=fast)
        {
            slow = slow.next;
            fast= fast.next;
        }

        return fast;
    }
}