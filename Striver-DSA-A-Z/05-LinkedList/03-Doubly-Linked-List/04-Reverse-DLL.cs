namespace Striver_DSA_A_Z._04_LinkedList._03_Doubly_Linked_List;

public partial class LinkedList
{
    public Node reverseDLL(Node head)
    {
        Node current = head;
        Node prev = null;

        while (current != null)
        {
            prev = current;
            current = current.next;
            prev.next = prev.prev;
            prev.prev = current;





        }
        return prev;
    }
}