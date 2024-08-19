namespace Striver_DSA_A_Z._04_LinkedList._04_Medium_Problems_DLL;

public partial class  LinkedList
{
    static Node deleteAllOccurOfX(Node head, int x) {
        // Write your code here
        //3 conditions head tail or middle

        while(head.data ==x)
        {
            head = head.next;
            head.prev = null;

        }
        Node current  = head;


        while(current.next!=null)
        {

            if(current.data == x)
            {
                current.prev.next =current.next;
                current.next.prev = current.prev;


            }

            current = current.next;
        }

        if(current.data ==x)
        {
            current.prev.next = null;
            current.prev = null;

        }
        return head;
    }
}