using Striver_DSA_A_Z._02_Arrays;

public class Solution
{
    public ListNode OddEvenList(ListNode head)
    {
        if (head == null || head?.next == null || head.next?.next == null)
            return head;

        ListNode odd = head;
        ListNode even = head.next;
        ListNode evenHead = head.next;
        while (even != null && even?.next != null && odd != null)
        {
            odd.next = even?.next;
            odd = even?.next;
            even.next = odd?.next;
            even = odd?.next;
        }

        odd.next = evenHead;



        return head;
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static void Main(string[] args)
    {
        int[] arr = new[]
        {
            1, 2, 2, 1, 0, 2, 2
        };
        var arr1 = new Arrays();
        arr1.SortColors(arr);
        foreach (var i in arr)
        {
            Console.WriteLine(i);
        }
    }

}