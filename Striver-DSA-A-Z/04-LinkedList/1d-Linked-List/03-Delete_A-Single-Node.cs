namespace Striver_DSA_A_Z._04_LinkedList._1d_Linked_List;

public partial class LinkedList {
    public void DeleteNode(ListNode node) {
        node.val = node.next.val;
        node.next = node.next.next;
    }
}


  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }