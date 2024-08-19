namespace Striver_DSA_A_Z._04_LinkedList._1d_Linked_List;

public partial class  LinkedList
{
    public static Node ConstructLL(int[] arr)
    {
        if (arr == null || arr.Length == 0)
            return null;

        Node head = new Node(arr[0]);
        Node current = head;

        for (int i = 1; i < arr.Length; i++)
        {
            Node newNode = new Node(arr[i]);
            current.next = newNode;
            current = newNode;
        }

        return head;
    }
}

public class Node {
   public int data;
   public Node next;

    public Node() { data = 0; }
    public Node(int d) { data = d; }  //constructor to create a new node
}