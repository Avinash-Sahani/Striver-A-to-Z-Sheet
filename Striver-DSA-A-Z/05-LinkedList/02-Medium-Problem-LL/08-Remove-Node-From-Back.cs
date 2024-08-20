namespace Striver_DSA_A_Z._04_LinkedList._02_Medium_Problem_LL;

public partial class LinkedList{
    public ListNode RemoveNthFromEnd(ListNode head, int n) {

        if(head == null)
            return head;
        if(head.next==null)
        {
            return null;
        }



        ListNode fast = head;
        ListNode slow = head;
        ListNode prevslow = null;
        while(n!=0 && fast!=null)
        {
            fast = fast.next;
            n--;
        }
        while(fast!=null )
        {
            prevslow = slow;
            slow = slow.next;
            fast=fast.next;
        }
        if(prevslow==null){

            prevslow = slow;
            slow = slow.next;
            prevslow.next= null;
            head = slow;
        }
        else
        {
            prevslow.next = slow.next;
            slow.next = null;
        }


        return head;
    }
}