namespace Striver_DSA_A_Z._04_LinkedList._04_Medium_Problems_DLL;

public partial class LinkedList
{
    Node removeDuplicates(Node head){
        Node current = head;

        if(current.next ==null)
            return head;
        Node temp = null;
        while(current.next!=null)
        {

            if(current.data ==current.next.data)
            {
                current.next = current.next.next;
                current.next.prev = current;
                // temp = current;

            }

            else

                current = current.next;
        }

        return head;

        // Code Here.

    }


}