namespace Striver_DSA_A_Z._04_LinkedList._03_Doubly_Linked_List;

public partial class LinkedList {

    Node constructDLL(int [] arr) {

        Node head = new Node(arr[0]);
        Node current = head;
        Node prev = null;
        for(int i=1; i<arr.Length; i++)
        {
            Node newNode = new Node(arr[i]);
            current.next = newNode;
            prev = current;
            current = current.next;
            current.prev = prev;
        }
        return head;
        // Code here
    }
}