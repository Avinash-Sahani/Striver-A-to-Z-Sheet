using Striver_DSA_A_Z._04_LinkedList._1d_Linked_List;

namespace Striver_DSA_A_Z._04_LinkedList._02_Medium_Problem_LL;

public partial class LinkedList
{
    public int CountNodesinLoop(Node head)
    {
        // code here


        if(head ==null || head.next ==null)
            return 0;

        Node fast = head;
        Node slow = head;

        while(fast!=null)
        {
            fast= fast?.next?.next;
            slow = slow.next;
            if(fast==slow)
                break;
        }

        if(fast==null)
            return 0;

        slow = head;
        int count = 0;
        while(slow!=fast)
        {
            slow  = slow.next;
            fast = fast.next;

        }
        fast = fast.next;
        while(fast!=slow)
        {
            count++;
            fast = fast.next;
        }
        return count+1;



    }
}