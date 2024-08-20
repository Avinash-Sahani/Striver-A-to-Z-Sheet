namespace Striver_DSA_A_Z._04_LinkedList._1d_Linked_List;

public partial class LinkedList {
    public bool searchKey(int n, Node head, int key) {

        Node current = head;
        if(current ==null)
            return false;

        while(current!=null)
        {
            if(current.data == key)
                return true;
            current = current.next;
        }
        return false;
        // Code here
    }
}