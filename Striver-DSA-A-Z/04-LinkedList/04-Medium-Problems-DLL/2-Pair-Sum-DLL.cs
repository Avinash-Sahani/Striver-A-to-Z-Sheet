namespace Striver_DSA_A_Z._04_LinkedList._04_Medium_Problems_DLL;

public partial class LinkedList {
    public static List<List<int>> FindPairsWithGivenSum(int target, Node head)
    {
        var pairs = new List<List<int>>();
        Node left = head;
        Node right = head;

        // Move to the end of the list
        while (right.next != null)
            right = right.next;

        while (left != right)
        {
            int sum = left.data + right.data;
            if (sum == target)
            {
                pairs.Add(new List<int> { left.data, right.data });
                right = right.prev;
            }
            else if (sum < target)
            {
                left = left.next;
            }
            else
            {
                right = right.prev;
            }
        }

        return pairs;
    }
}