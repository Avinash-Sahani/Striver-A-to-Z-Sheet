namespace Striver_DSA_A_Z._04_LinkedList._1d_Linked_List;

public partial class LinkedList{
    public Node InsertAtEnd(Node head, int x) {

        Node newnode = new Node(x);
        if(head ==null)
            return newnode;


        Node current = head;

        while(current.next!=null)
        {
            current = current.next;
        }
        current.next = newnode;
        return head;
        // code here
    }
}