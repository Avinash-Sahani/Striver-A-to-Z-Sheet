namespace Striver_DSA_A_Z._04_LinkedList._02_Medium_Problem_LL;

public partial class LinkedList {
    public ListNode OddEvenList(ListNode head) {
        if(head == null || head?.next==null || head.next?.next==null)
            return head;

        ListNode odd = head;
        ListNode even = head.next;
        ListNode evenHead = head.next;
        while (even != null && even?.next != null && odd != null)
        {
            odd.next = even?.next;
            odd = even?.next;
            even.next = odd?.next;
            even = odd?.next;
        }

        odd.next = evenHead;



        return head;
    }
}