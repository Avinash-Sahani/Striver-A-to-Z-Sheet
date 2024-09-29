namespace Striver_DSA_A_Z._06_Bit_Manipulation;

public partial class BitManipulation {

    public bool checkKthBit(int n, int k)
    {
        return ((n>>k)&1)==1;
    }

}