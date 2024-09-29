namespace Striver_DSA_A_Z._06_Bit_Manipulation;

public partial class  BitManipulation {
    public static List<int> Swap(int a, int b)
    {
        // code here
        a = a ^ b;
        b = a ^ b;
        a = a ^ b;

        List<int> list = new List<int>();
        list.Add(a);
        list.Add(b);
        return list;
    }
}