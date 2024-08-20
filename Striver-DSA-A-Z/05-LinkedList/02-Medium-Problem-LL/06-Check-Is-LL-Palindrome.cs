namespace Striver_DSA_A_Z._04_LinkedList._02_Medium_Problem_LL;

public partial class LinkedList {
    public ListNode ReverseLL(ListNode head)
    {

        if( head==null || head.next ==null )
            return head;
        ListNode current = head.next;
        ListNode prev = head;
        ListNode secondPrev = null;

        while(current!=null )
        {
            prev.next = secondPrev;
            secondPrev = prev;
            prev = current;
            current = current.next;
        }
        prev.next = secondPrev;
        return prev;
    }
    public bool IsPalindrome(ListNode head) {

        if(head == null || head.next==null)
            return true;
        ListNode current = head;
        ListNode prev = head;

        while(current?.next!=null)
        {
            current=current?.next?.next;
            prev = prev?.next;
        }
        ListNode reversed = ReverseLL(prev);
        ListNode first  = head;
        ListNode second= reversed;
        while(second!=null && first?.val == second?.val)
        {
            first= first?.next;
            second = second?.next;
        }
        if(second!=null)
            return false;

        return true;
    }
}