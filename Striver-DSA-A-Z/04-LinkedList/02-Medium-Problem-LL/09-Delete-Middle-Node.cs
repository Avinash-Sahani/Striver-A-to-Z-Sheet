namespace Striver_DSA_A_Z._04_LinkedList._02_Medium_Problem_LL;

public partial class LinkedList
{
    public ListNode DeleteMiddle(ListNode head) {
        ListNode slow = head;
        ListNode fast  = head;
        ListNode prevslow = null;
        if(head==null || head.next==null)
        {
            head =null;
            return head;
        }


        while(fast!=null && fast.next!=null )
        {
            fast = fast.next?.next;
            prevslow = slow;
            slow = slow.next;
        }

        prevslow.next = slow.next;
        slow.next = null;
        return head;


    }
}