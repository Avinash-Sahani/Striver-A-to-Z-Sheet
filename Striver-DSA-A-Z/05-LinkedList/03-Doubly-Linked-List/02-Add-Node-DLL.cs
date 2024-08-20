namespace Striver_DSA_A_Z._04_LinkedList._03_Doubly_Linked_List;

public partial class LinkedList {
     void addNode(Node head_ref, int pos, int data)
	{

        Node current = head_ref;

            while(pos!=1)
            {

                current = current.next;
                 pos--;
            }
            Node newNode = new Node(data);
            newNode.next = current.next;
            newNode.prev = current;
            current.next.prev = newNode;
            current.next = newNode;

	}
}