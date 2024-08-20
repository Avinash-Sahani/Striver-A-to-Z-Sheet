namespace Striver_DSA_A_Z._04_LinkedList._1d_Linked_List;

public partial class LinkedList
{
    public int getCount(Node head) {
        // code here

        if(head ==null)
            return 0;
        int count = 0;
        Node current = head;
        while(current!=null)
        {
            count++;
            current = current.next;

        }
        return count;
    }
}