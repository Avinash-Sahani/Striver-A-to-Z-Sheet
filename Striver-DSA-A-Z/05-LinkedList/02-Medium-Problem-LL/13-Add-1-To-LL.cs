namespace Striver_DSA_A_Z._04_LinkedList._02_Medium_Problem_LL;

public partial class LinkedList{
    public ListNode AddToLast(ListNode head ,int num)
    {

        if(head == null)
        {
            head = new ListNode(num);
        }
        else
        {
            ListNode current = head;
            while(current?.next!=null)
                current = current.next;
            current.next =  new ListNode(num);
        }
        return head;
    }
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

        ListNode head = null;
        int carry = 0;
        while(l2!=null && l1!=null)
        {

            int sum = l1.val + l2.val + carry;
            carry = sum /10;
            int num  = sum%10;
            head = AddToLast(head,num);
            l1 = l1.next;
            l2 = l2.next;
        }
        ListNode current = l2;
        if(l1!=null)
            current = l1;
        while(current!=null)
        {
            int sum = current.val + carry;
            carry = sum /10;
            int num  = sum%10;
            head = AddToLast(head,num);
            current = current.next;
        }
        if(carry!=0)
            AddToLast(head,carry);

        return head;




    }
}