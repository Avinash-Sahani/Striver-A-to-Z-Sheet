namespace Striver_DSA_A_Z._04_LinkedList._03_Doubly_Linked_List;

public partial class  LinkedList
{
    public Node DeleteNode(Node head, int x) {

        Node current =head;

        if(x==1)
        {
            head = current.next;
            current.next = null;
            return head;

        }
        while(x!=1)
        {
            current = current.next;
            x--;
        }
        if(current.next!=null)
        {
            current.prev.next = current.next;
            current.next.prev = current.prev;
            current.next = null;
            current.prev = null;
        }
        else
        {
            current.prev.next = null;
        }




        return head;
    }
}