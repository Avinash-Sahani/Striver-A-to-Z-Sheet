namespace Striver_DSA_A_Z._04_LinkedList._02_Medium_Problem_LL;

public partial class LinkedList {

    public ListNode AddToLL(ListNode list,int n)
    {
        ListNode nodeToadd = new ListNode(n);
        if(list==null)
        {
            list = nodeToadd;
            return list;
        }
        list.next=nodeToadd;
        list = list.next;
        return list;
    }
    public ListNode MergeLists(ListNode l1, ListNode l2)
    {

        ListNode temp = new ListNode(-1);
        ListNode list = temp;



        while(l1!=null && l2!=null)
        {

            if(l1.val <= l2.val)
            {
                list = AddToLL(list,l1.val);
                l1 = l1.next;

            }
            else
            {
                list = AddToLL(list,l2.val);
                l2 = l2.next;
            }

        }

        while(l1!=null)
        {
            list = AddToLL(list,l1.val);
            l1 = l1.next;
        }
        while(l2!=null)
        {
            list = AddToLL(list,l2.val);
            l2 = l2.next;
        }

        return temp.next;


    }


    public ListNode findMiddle(ListNode head)
    {

        if (head == null || head.next == null) {
            return head;
        }


        ListNode fast = head.next;
        ListNode slow = head;
        while(fast?.next!=null)
        {
            fast = fast.next?.next;
            slow = slow.next;
        }
        return slow;
    }
    public ListNode SortList(ListNode head) {

        if(head==null || head.next==null)
            return head;

        ListNode middle = findMiddle(head);
        ListNode right = middle?.next;
        middle.next = null;
        ListNode left = head;

        left = SortList(left);
        right = SortList(right);

        return MergeLists(left,right);


    }
}