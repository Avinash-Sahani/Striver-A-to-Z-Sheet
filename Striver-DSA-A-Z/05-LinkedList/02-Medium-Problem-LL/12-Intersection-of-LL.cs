namespace Striver_DSA_A_Z._04_LinkedList._02_Medium_Problem_LL;

public partial class LinkedList {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {

        if(headA==null || headB==null)
            return null;
        ListNode L1 = headA;
        ListNode L2 = headB;
        int len1 = 0;
        int len2 = 0;
        while(L1!=null)
        {
            L1 = L1.next;
            len1++;
        }
        while(L2!=null)
        {
            L2 = L2.next;
            len2++;
        }
        L1 = headA;
        L2 = headB;
        int diff = Math.Abs(len1-len2);
        if(len1>len2)
        {
            while(diff--!=0)
                L1= L1.next;
        }
        else
            while(diff--!=0)
                L2= L2.next;

        while(L1!=null && L2!=null)
        {

            if(L1==L2)
                return L1;
            L1 = L1.next;
            L2 = L2.next;
        }
        return null;


    }
}